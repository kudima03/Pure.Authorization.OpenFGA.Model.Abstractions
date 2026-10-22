# Pure.Authorization.OpenFGA.Model.Abstractions

OpenFGA authorization model interfaces for the **Pure** ecosystem — immutable, composable abstractions over objects, subjects, tuples, type definitions, relation rewrites and conditions.

[![.NET build & test](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Authorization.OpenFGA.Model.Abstractions)](https://www.nuget.org/packages/Pure.Authorization.OpenFGA.Model.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Authorization.OpenFGA.Model.Abstractions` defines a set of minimal, read-only interfaces that describe an [OpenFGA](https://openfga.dev) authorization model and the relationship tuples written against it. Each interface exposes only getters — no mutation, no side effects. All string properties are typed as `IString` from `Pure.Primitives.Abstractions`, keeping the model decoupled from concrete string representations and from any particular OpenFGA client SDK.

## Interfaces

Each concept lives in its own folder and namespace under `Pure.Authorization.OpenFGA.Model.Abstractions`.

| Interface | Namespace | Description |
|-----------|-----------|-------------|
| `IAuthorizationModel` | `.Model` | Root model — schema version, type definitions and conditions |
| `ITypeDefinition` | `.Model` | Object type — name and the relations defined on it |
| `IRelationDefinition` | `.Model` | Relation — name and the rewrite that defines it |
| `IRewrite` | `.Rewrite` | Base of the relation-definition expression tree (closed set of nodes) |
| `IDirect` | `.Rewrite` | Directly assignable — `[user, group#member]` |
| `IComputedRelation` | `.Rewrite` | Another relation on the same object — `editor` |
| `IRelationFrom` | `.Rewrite` | A relation on related objects — `viewer from parent` |
| `IUnion` | `.Rewrite` | Any of the children — `a or b` |
| `IIntersection` | `.Rewrite` | All of the children — `a and b` |
| `IDifference` | `.Rewrite` | Base minus subtracted part — `a but not b` |
| `ISubjectForm` | `.SubjectForm` | Base of the forms a relation can be written for directly (closed set) |
| `ITypeForm` | `.SubjectForm` | Any object of a type — `user` |
| `ISubjectSetForm` | `.SubjectForm` | Holders of a relation on a type — `group#member` |
| `IWildcardForm` | `.SubjectForm` | Every object of a type — `user:*` |
| `IConditionalForm` | `.SubjectForm` | A non-conditional form plus a condition name — `user with non_expired` |
| `ICondition` | `.Condition` | ABAC condition — name, CEL expression and parameters |
| `IConditionParameter` | `.Condition` | Condition parameter — name and type |
| `IConditionParameterType` | `.Condition` | Parameter type — name and generic type arguments (`list<string>`) |
| `ISubject` | `.Subject` | Base of the subjects of a tuple (closed set) |
| `ISubjectSet` | `.Subject` | Holders of a relation on an object — `group:1#member` |
| `ITypedWildcard` | `.Subject` | Every object of a type — `user:*` |
| `IObject` | `.Object` | Object — type and id, `document:1`; also usable as a subject |
| `ITuple` | `.Tuple` | Relationship tuple — subject, relation and object |
| `IConditionalTuple` | `.Tuple` | A tuple decorated with a relationship condition |
| `IRelationshipCondition` | `.Tuple` | Condition name and JSON context stored with a tuple |

`IRewrite`, `ISubjectForm` and `ISubject` have no members: each is the base of a closed set of variants, and consumers pattern-match on the concrete interface.

## OpenFGA Naming

Names follow the OpenFGA DSL rather than the JSON/API wire format. Where they differ:

| This package | OpenFGA JSON / API |
|--------------|--------------------|
| `ISubject` | `user` (the left-hand side of a tuple) |
| `ISubjectSet` | userset (`type:id#relation`) |
| `ITypedWildcard` | `TypedWildcard` (`type:*`) |
| `IRewrite` | `Userset` |
| `IDirect` | `this` + `directly_related_user_types` |
| `IComputedRelation` | `computedUserset` |
| `IRelationFrom` | `tupleToUserset` (`Tupleset` = `tupleset.relation`, `Relation` = `computedUserset.relation`) |
| `ISubjectForm` | `RelationReference` (an entry of `directly_related_user_types`) |
| `ITuple` | `TupleKey` |
| `IRelationshipCondition` | `RelationshipCondition` |

## Design Principles

- **Immutable** — all interfaces expose only `get` properties; no setters, no methods that mutate state.
- **Composable** — complex structure is expressed through composition and `IEnumerable<T>` collections, allowing traversal without committing to a concrete collection type.
- **Primitive-typed** — string properties use `IString` from `Pure.Primitives.Abstractions`, not `System.String`, keeping the model framework-agnostic.
- **AOT-compatible** — the library sets `IsAotCompatible=true` and contains no reflection or code generation.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions/tree/4.3.0) — base interfaces for immutable primitive types (`IString`, `INumber<T>`, etc.)

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```shell
dotnet add package Pure.Authorization.OpenFGA.Model.Abstractions
```

## Usage

The closed sets (`IRewrite`, `ISubjectForm`, `ISubject`) are consumed by pattern matching. For example, rendering a relation definition back to the OpenFGA DSL:

```csharp
using System.Linq;
using Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;
using Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

static string Dsl(IRewrite rewrite) =>
    rewrite switch
    {
        IDirect direct => $"[{string.Join(", ", direct.Forms.Select(FormDsl))}]",
        IComputedRelation computed => computed.Relation.TextValue,
        IRelationFrom from => $"{from.Relation.TextValue} from {from.Tupleset.TextValue}",
        IUnion union => $"({string.Join(" or ", union.Children.Select(Dsl))})",
        IIntersection both => $"({string.Join(" and ", both.Children.Select(Dsl))})",
        IDifference diff => $"({Dsl(diff.Base)} but not {Dsl(diff.Subtract)})",
        _ => throw new NotSupportedException(rewrite.GetType().Name),
    };

static string FormDsl(ISubjectForm form) =>
    form switch
    {
        ITypeForm type => type.Type.TextValue,
        ISubjectSetForm set => $"{set.Type.TextValue}#{set.Relation.TextValue}",
        IWildcardForm wildcard => $"{wildcard.Type.TextValue}:*",
        IConditionalForm conditional =>
            $"{FormDsl(conditional.Form)} with {conditional.Condition.TextValue}",
        _ => throw new NotSupportedException(form.GetType().Name),
    };
```

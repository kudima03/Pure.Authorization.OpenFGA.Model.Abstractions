# Pure.Authorization.OpenFGA.Model.Abstractions

OpenFGA authorization model interfaces for the **Pure** ecosystem — immutable, composable abstractions over objects, subjects, tuples, type definitions, relation rewrites and conditions.

[![.NET build & test](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Authorization.OpenFGA.Model.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Authorization.OpenFGA.Model.Abstractions)](https://www.nuget.org/packages/Pure.Authorization.OpenFGA.Model.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Authorization.OpenFGA.Model.Abstractions` defines a set of minimal, read-only interfaces that describe an [OpenFGA](https://openfga.dev) authorization model and the relationship tuples written against it. Each interface exposes only getters — no mutation, no side effects. All string properties are typed as `IString` from `Pure.Primitives.Abstractions`, keeping the model decoupled from concrete string representations and from any particular OpenFGA client SDK.

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

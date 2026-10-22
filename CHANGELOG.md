# Changelog

All notable changes to Pure.Authorization.OpenFGA.Model.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.0.1.0] — 2026-10-22

### Added

- **Model** (`.Model`) — `IAuthorizationModel` (`SchemaVersion`, `Types`,
  `Conditions`), `ITypeDefinition` (`Name`, `Relations`) and
  `IRelationDefinition` (`Name`, `Rewrite`).
- **Relation rewrites** (`.Rewrite`) — `IRewrite`, the base of a closed set of
  expression-tree nodes: `IDirect` (`[user, group#member]`),
  `IComputedRelation` (`editor`), `IRelationFrom` (`viewer from parent`),
  `IUnion` (`or`), `IIntersection` (`and`) and `IDifference` (`but not`).
- **Subject forms** (`.SubjectForm`) — `ISubjectForm`, the base of the forms a
  relation can be written for directly: `ITypeForm` (`user`),
  `ISubjectSetForm` (`group#member`), `IWildcardForm` (`user:*`) and
  `IConditionalForm` (`user with non_expired`).
- **Conditions** (`.Condition`) — `ICondition` (`Name`, CEL `Expression`,
  `Parameters`), `IConditionParameter` (`Name`, `Type`) and
  `IConditionParameterType` (`Name`, `GenericTypes`).
- **Subjects and objects** (`.Subject`, `.Object`) — `ISubject`, the base of
  the tuple subjects `IObject` (`document:1`), `ISubjectSet`
  (`group:1#member`) and `ITypedWildcard` (`user:*`).
- **Tuples** (`.Tuple`) — `ITuple` (`Subject`, `Relation`, `Object`),
  `IConditionalTuple` decorating a tuple with an `IRelationshipCondition`
  (`Name`, `JsonNode` `Context`).
- Dependency on `Pure.Primitives.Abstractions` 4.3.0 for `IString`.

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// A node of a relation's definition, expressed as an expression tree with one node per
/// DSL construct (OpenFGA <c>Userset</c>). This is the base of a closed set of variants:
/// <see cref="IDirect"/>, <see cref="IComputedRelation"/>, <see cref="IRelationFrom"/>,
/// <see cref="IUnion"/>, <see cref="IIntersection"/> and <see cref="IDifference"/>.
/// Consumers pattern-match on the variant.
/// </summary>
public interface IRewrite;

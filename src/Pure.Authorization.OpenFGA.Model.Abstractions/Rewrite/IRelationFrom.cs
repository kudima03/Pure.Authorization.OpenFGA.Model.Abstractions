using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// Whoever holds a relation on the objects related through a tupleset relation.
/// DSL: <c>viewer from parent</c>, where <see cref="Relation"/> is <c>viewer</c> and
/// <see cref="Tupleset"/> is <c>parent</c>. OpenFGA: <c>tupleToUserset</c>.
/// </summary>
public interface IRelationFrom : IRewrite
{
    /// <summary>
    /// The relation looked up on the related objects, e.g. <c>viewer</c> (OpenFGA
    /// <c>computedUserset</c>).
    /// </summary>
    public IString Relation { get; }

    /// <summary>
    /// The relation on this object that points at the related objects, e.g. <c>parent</c>
    /// (OpenFGA <c>tupleset</c>).
    /// </summary>
    public IString Tupleset { get; }
}

using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// Whoever holds another relation on the same object. DSL: <c>editor</c>.
/// OpenFGA: <c>computedUserset</c>.
/// </summary>
public interface IComputedRelation : IRewrite
{
    /// <summary>
    /// The relation on the same object, e.g. <c>editor</c>.
    /// </summary>
    public IString Relation { get; }
}

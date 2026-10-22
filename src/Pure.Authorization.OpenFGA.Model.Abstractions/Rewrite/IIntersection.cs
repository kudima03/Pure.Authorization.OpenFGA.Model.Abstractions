using System.Collections.Generic;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// Holders of all of the children. DSL: <c>a and b</c>. OpenFGA: <c>intersection</c>.
/// </summary>
public interface IIntersection : IRewrite
{
    /// <summary>
    /// The operands of the intersection.
    /// </summary>
    public IEnumerable<IRewrite> Children { get; }
}

using System.Collections.Generic;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// Holders of any of the children. DSL: <c>a or b</c>. OpenFGA: <c>union</c>.
/// </summary>
public interface IUnion : IRewrite
{
    /// <summary>
    /// The operands of the union.
    /// </summary>
    public IEnumerable<IRewrite> Children { get; }
}

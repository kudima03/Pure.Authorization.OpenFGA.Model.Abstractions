namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// Holders of the base who do not hold the subtracted part. DSL: <c>a but not b</c>.
/// OpenFGA: <c>difference</c>.
/// </summary>
public interface IDifference : IRewrite
{
    /// <summary>
    /// The expression subtracted from, <c>a</c> in <c>a but not b</c>.
    /// </summary>
    public IRewrite Base { get; }

    /// <summary>
    /// The expression subtracted, <c>b</c> in <c>a but not b</c>.
    /// </summary>
    public IRewrite Subtract { get; }
}

using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Subject;

/// <summary>
/// Every object of a type. Written as <c>user:*</c> (OpenFGA <c>TypedWildcard</c>).
/// </summary>
public interface ITypedWildcard : ISubject
{
    /// <summary>
    /// The object type, e.g. <c>user</c>.
    /// </summary>
    public IString Type { get; }
}

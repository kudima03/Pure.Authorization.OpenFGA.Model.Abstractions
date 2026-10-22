using Pure.Authorization.OpenFGA.Model.Abstractions.Subject;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Object;

/// <summary>
/// An object of a type, written as <c>document:1</c>. Any object can also act as the
/// subject of a tuple (e.g. <c>user:anne</c>), so this interface is also an
/// <see cref="ISubject"/>.
/// </summary>
public interface IObject : ISubject
{
    /// <summary>
    /// The object type, e.g. <c>document</c>.
    /// </summary>
    public IString Type { get; }

    /// <summary>
    /// The object identifier within its type, e.g. <c>1</c>.
    /// </summary>
    public IString Id { get; }
}

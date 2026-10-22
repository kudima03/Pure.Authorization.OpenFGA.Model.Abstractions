using Pure.Authorization.OpenFGA.Model.Abstractions.Object;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Subject;

/// <summary>
/// Every subject holding a relation on an object. Written as <c>group:1#member</c>
/// (OpenFGA userset).
/// </summary>
public interface ISubjectSet : ISubject
{
    /// <summary>
    /// The object, e.g. <c>group:1</c>.
    /// </summary>
    public IObject Object { get; }

    /// <summary>
    /// The relation on the object, e.g. <c>member</c>.
    /// </summary>
    public IString Relation { get; }
}

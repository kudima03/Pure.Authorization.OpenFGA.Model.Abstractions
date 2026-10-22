using Pure.Authorization.OpenFGA.Model.Abstractions.Object;
using Pure.Authorization.OpenFGA.Model.Abstractions.Subject;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Tuple;

/// <summary>
/// A relationship tuple: the subject holds the relation on the object.
/// Written as <c>user:anne viewer document:1</c> (OpenFGA <c>TupleKey</c>).
/// </summary>
public interface ITuple
{
    /// <summary>
    /// Who holds the relation (OpenFGA <c>user</c>).
    /// </summary>
    public ISubject Subject { get; }

    /// <summary>
    /// The relation held, e.g. <c>viewer</c>.
    /// </summary>
    public IString Relation { get; }

    /// <summary>
    /// The object the relation is held on, e.g. <c>document:1</c>.
    /// </summary>
    public IObject Object { get; }
}

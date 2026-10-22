using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

/// <summary>
/// The set of subjects holding a relation on an object of a type.
/// DSL: <c>group#member</c>.
/// </summary>
public interface ISubjectSetForm : ISubjectForm
{
    /// <summary>
    /// The object type, e.g. <c>group</c>.
    /// </summary>
    public IString Type { get; }

    /// <summary>
    /// The relation on that type, e.g. <c>member</c>.
    /// </summary>
    public IString Relation { get; }
}

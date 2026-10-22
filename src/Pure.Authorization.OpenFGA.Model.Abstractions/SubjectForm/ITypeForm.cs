using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

/// <summary>
/// Any single object of a type. DSL: <c>user</c>.
/// </summary>
public interface ITypeForm : ISubjectForm
{
    /// <summary>
    /// The object type, e.g. <c>user</c>.
    /// </summary>
    public IString Type { get; }
}

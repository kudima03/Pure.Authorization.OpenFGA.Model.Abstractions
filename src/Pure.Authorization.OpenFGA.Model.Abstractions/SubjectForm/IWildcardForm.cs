using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

/// <summary>
/// Every object of a type, written as a public-access wildcard. DSL: <c>user:*</c>.
/// </summary>
public interface IWildcardForm : ISubjectForm
{
    /// <summary>
    /// The object type, e.g. <c>user</c>.
    /// </summary>
    public IString Type { get; }
}

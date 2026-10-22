using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

/// <summary>
/// A subject form that may only be written together with a condition.
/// DSL: <c>[user with non_expired]</c>.
/// </summary>
public interface IConditionalForm : ISubjectForm
{
    /// <summary>
    /// The form being conditioned. It is never another <see cref="IConditionalForm"/>:
    /// a form carries at most one condition.
    /// </summary>
    public ISubjectForm Form { get; }

    /// <summary>
    /// The name of an <c>ICondition</c> defined in the same authorization model,
    /// e.g. <c>non_expired</c>.
    /// </summary>
    public IString Condition { get; }
}

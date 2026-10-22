using System.Collections.Generic;
using Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;

/// <summary>
/// The relation can be written directly in tuples for the listed subject forms.
/// DSL: <c>[user, group#member]</c>. OpenFGA: <c>this</c>, with the forms stored as the
/// relation's <c>directly_related_user_types</c>.
/// </summary>
public interface IDirect : IRewrite
{
    /// <summary>
    /// The subject forms a tuple for this relation may name.
    /// </summary>
    public IEnumerable<ISubjectForm> Forms { get; }
}

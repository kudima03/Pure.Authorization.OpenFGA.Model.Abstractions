namespace Pure.Authorization.OpenFGA.Model.Abstractions.SubjectForm;

/// <summary>
/// A form of subject a relation can be written for directly, one entry of a direct
/// relation's type restrictions (OpenFGA <c>RelationReference</c>, listed in
/// <c>directly_related_user_types</c>). This is the base of a closed set of variants:
/// <see cref="ITypeForm"/>, <see cref="ISubjectSetForm"/>, <see cref="IWildcardForm"/>
/// and <see cref="IConditionalForm"/>. Consumers pattern-match on the variant.
/// </summary>
public interface ISubjectForm;

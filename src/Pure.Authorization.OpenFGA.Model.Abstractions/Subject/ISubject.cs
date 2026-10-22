namespace Pure.Authorization.OpenFGA.Model.Abstractions.Subject;

/// <summary>
/// The subject of a relationship tuple, who or what is granted the relation (OpenFGA
/// "user"). This is the base of a closed set of variants: <see cref="Object.IObject"/>,
/// <see cref="ISubjectSet"/> and <see cref="ITypedWildcard"/>. Consumers pattern-match on
/// the variant.
/// </summary>
public interface ISubject;

using Pure.Authorization.OpenFGA.Model.Abstractions.Rewrite;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Model;

/// <summary>
/// A relation of a type definition. DSL: <c>define viewer: [user] or editor</c>.
/// </summary>
public interface IRelationDefinition
{
    /// <summary>
    /// The relation name, e.g. <c>viewer</c>.
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The expression that defines who holds the relation (OpenFGA <c>Userset</c>).
    /// </summary>
    public IRewrite Rewrite { get; }
}

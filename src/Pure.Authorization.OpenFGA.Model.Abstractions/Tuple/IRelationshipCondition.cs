using System.Text.Json.Nodes;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Tuple;

/// <summary>
/// The condition attached to a tuple (OpenFGA <c>RelationshipCondition</c>).
/// </summary>
public interface IRelationshipCondition
{
    /// <summary>
    /// The name of a condition defined in the authorization model,
    /// e.g. <c>non_expired</c>.
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The parameter values stored with the tuple, as a JSON object
    /// (OpenFGA <c>context</c>).
    /// </summary>
    public JsonNode Context { get; }
}

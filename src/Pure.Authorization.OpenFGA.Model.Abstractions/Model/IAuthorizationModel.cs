using System.Collections.Generic;
using Pure.Authorization.OpenFGA.Model.Abstractions.Condition;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Model;

/// <summary>
/// An OpenFGA authorization model: the type definitions that make up the schema and the
/// conditions their relations may reference.
/// </summary>
public interface IAuthorizationModel
{
    /// <summary>
    /// The OpenFGA schema version the model is written against (OpenFGA
    /// <c>schema_version</c>, e.g. <c>1.1</c>).
    /// </summary>
    public IString SchemaVersion { get; }

    /// <summary>
    /// The object types of the model (OpenFGA <c>type_definitions</c>).
    /// </summary>
    public IEnumerable<ITypeDefinition> Types { get; }

    /// <summary>
    /// The ABAC conditions that relations of the model may reference by name.
    /// </summary>
    public IEnumerable<ICondition> Conditions { get; }
}

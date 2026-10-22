using System.Collections.Generic;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Model;

/// <summary>
/// An object type of the model and the relations defined on it. DSL: <c>type document</c>
/// followed by its <c>relations</c> block.
/// </summary>
public interface ITypeDefinition
{
    /// <summary>
    /// The type name, e.g. <c>document</c> (OpenFGA <c>type</c>).
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The relations defined on the type.
    /// </summary>
    public IEnumerable<IRelationDefinition> Relations { get; }
}

using System.Collections.Generic;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Condition;

/// <summary>
/// The type of a condition parameter. DSL: <c>timestamp</c>, <c>list&lt;string&gt;</c>.
/// </summary>
public interface IConditionParameterType
{
    /// <summary>
    /// The type name: one of <c>bool</c>, <c>string</c>, <c>int</c>, <c>uint</c>,
    /// <c>double</c>, <c>duration</c>, <c>timestamp</c>, <c>ipaddress</c>, <c>any</c>,
    /// <c>map</c> or <c>list</c>.
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The type arguments: <c>T</c> of <c>map&lt;T&gt;</c> or <c>list&lt;T&gt;</c>;
    /// empty for non-generic types (OpenFGA <c>generic_types</c>).
    /// </summary>
    public IEnumerable<IConditionParameterType> GenericTypes { get; }
}

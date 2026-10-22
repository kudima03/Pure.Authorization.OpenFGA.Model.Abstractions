using System.Collections.Generic;
using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Condition;

/// <summary>
/// An OpenFGA ABAC condition: a named CEL expression over typed parameters.
/// DSL: <c>condition non_expired(grant_time: timestamp, duration: duration) { ... }</c>.
/// </summary>
public interface ICondition
{
    /// <summary>
    /// The condition name that subject forms and tuples refer to,
    /// e.g. <c>non_expired</c>.
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The CEL expression, e.g. <c>current_time &lt; grant_time + duration</c>.
    /// </summary>
    public IString Expression { get; }

    /// <summary>
    /// The typed parameters the expression reads.
    /// </summary>
    public IEnumerable<IConditionParameter> Parameters { get; }
}

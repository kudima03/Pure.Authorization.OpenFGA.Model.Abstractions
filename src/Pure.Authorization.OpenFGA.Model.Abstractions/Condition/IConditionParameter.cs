using Pure.Primitives.Abstractions.String;

namespace Pure.Authorization.OpenFGA.Model.Abstractions.Condition;

/// <summary>
/// A typed parameter of a condition. DSL: <c>grant_time: timestamp</c>.
/// </summary>
public interface IConditionParameter
{
    /// <summary>
    /// The parameter name, e.g. <c>grant_time</c>.
    /// </summary>
    public IString Name { get; }

    /// <summary>
    /// The parameter type, e.g. <c>timestamp</c>.
    /// </summary>
    public IConditionParameterType Type { get; }
}

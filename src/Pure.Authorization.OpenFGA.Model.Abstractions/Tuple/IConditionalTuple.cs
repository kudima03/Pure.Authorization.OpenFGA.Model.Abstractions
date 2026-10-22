namespace Pure.Authorization.OpenFGA.Model.Abstractions.Tuple;

/// <summary>
/// A tuple that holds only while its condition evaluates to true. It decorates a tuple:
/// the subject, relation and object come from <see cref="ITuple"/> itself, and only the
/// condition is added.
/// </summary>
public interface IConditionalTuple : ITuple
{
    /// <summary>
    /// The condition the tuple is written with, and its stored context.
    /// </summary>
    public IRelationshipCondition Condition { get; }
}

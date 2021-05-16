namespace HM.HM5.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints8
    {
        ImmutableList<IConstraints8ConstraintElement> Value { get; }
    }
}
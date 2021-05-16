namespace HM.HM5.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;

    public interface Isrd2t
    {
        ImmutableList<Isrd2tCrossJoinElement> Value { get; }
    }
}
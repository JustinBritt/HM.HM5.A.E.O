namespace HM.HM5.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;

    public interface Ird1d2
    {
        ImmutableList<Ird1d2CrossJoinElement> Value { get; }
    }
}
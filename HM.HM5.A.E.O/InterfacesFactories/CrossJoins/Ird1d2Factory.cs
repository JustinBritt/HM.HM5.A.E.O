namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;

    public interface Ird1d2Factory
    {
        Ird1d2 Create(
            ImmutableList<Ird1d2CrossJoinElement> value);
    }
}
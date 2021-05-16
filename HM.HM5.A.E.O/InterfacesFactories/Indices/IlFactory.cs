namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface IlFactory
    {
        Il Create(
            ImmutableList<IlIndexElement> value);
    }
}
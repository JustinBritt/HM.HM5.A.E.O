namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface ItFactory
    {
        It Create(
            ImmutableList<ItIndexElement> value);
    }
}
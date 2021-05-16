namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface Id2Factory
    {
        Id2 Create(
            ImmutableList<Id2IndexElement> value);
    }
}
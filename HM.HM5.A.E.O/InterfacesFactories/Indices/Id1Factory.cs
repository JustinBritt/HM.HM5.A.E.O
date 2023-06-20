namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface Id1Factory
    {
        Id1 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value);
    }
}
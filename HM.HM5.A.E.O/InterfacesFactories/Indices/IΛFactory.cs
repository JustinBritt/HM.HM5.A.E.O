namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface IΛFactory
    {
        IΛ Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IΛIndexElement> value);
    }
}
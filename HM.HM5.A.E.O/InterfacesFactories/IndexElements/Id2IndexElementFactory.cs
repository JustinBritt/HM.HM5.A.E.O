namespace HM.HM5.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Id2IndexElementFactory
    {
        Id2IndexElement Create(
            INullableValue<int> value);
    }
}
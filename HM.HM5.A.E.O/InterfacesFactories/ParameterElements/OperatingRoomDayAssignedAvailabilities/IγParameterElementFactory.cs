namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    public interface IγParameterElementFactory
    {
        IγParameterElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            FhirBoolean value);
    }
}
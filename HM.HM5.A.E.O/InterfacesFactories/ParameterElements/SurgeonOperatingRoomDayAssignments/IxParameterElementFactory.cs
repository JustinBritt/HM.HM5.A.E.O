namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;

    public interface IxParameterElementFactory
    {
        IxParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            FhirBoolean value);
    }
}
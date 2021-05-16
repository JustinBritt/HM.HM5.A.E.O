namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;

    public interface IyParameterElementFactory
    {
        IyParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value);
    }
}
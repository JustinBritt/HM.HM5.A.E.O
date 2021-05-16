namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IxParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        FhirBoolean Value { get; }
    }
}
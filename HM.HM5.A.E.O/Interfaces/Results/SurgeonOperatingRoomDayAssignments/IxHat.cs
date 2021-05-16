namespace HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IxHat
    {
        ImmutableList<IxHatResultElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
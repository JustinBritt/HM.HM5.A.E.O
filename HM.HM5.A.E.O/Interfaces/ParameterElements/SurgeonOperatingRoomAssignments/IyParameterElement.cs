﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IyParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        FhirBoolean Value { get; }
    }
}
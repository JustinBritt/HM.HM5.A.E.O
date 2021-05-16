﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IμParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        FhirDecimal Value { get; }
    }
}
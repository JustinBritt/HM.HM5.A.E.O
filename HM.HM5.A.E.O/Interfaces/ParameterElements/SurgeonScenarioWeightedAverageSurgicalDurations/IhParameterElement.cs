﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IhParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        Duration Value { get; }
    }
}
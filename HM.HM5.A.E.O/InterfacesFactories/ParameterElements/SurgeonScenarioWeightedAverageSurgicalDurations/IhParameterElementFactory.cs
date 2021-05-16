﻿namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;

    public interface IhParameterElementFactory
    {
        IhParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Duration value);
    }
}
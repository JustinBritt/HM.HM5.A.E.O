﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IpParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}
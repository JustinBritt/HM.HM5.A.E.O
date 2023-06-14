﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IΦHatParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}
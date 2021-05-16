﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface ILParameterElement
    {
        IsIndexElement sIndexElement { get; }

        PositiveInt Value { get; }
    }
}
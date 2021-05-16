﻿namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System.Collections.Immutable;
  
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface In
    {
        ImmutableList<InParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}
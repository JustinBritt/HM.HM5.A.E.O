﻿namespace HM.HM5.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IVarianceI
    {
        ImmutableList<IVarianceIResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement);

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
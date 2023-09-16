﻿namespace HM.HM5.A.E.O.Interfaces.Results.ScenarioNumberPatients
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioNumberPatients
    {
        ImmutableList<IScenarioNumberPatientsResultElement> Value { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
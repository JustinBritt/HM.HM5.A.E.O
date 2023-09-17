﻿namespace HM.HM5.A.E.O.Classes.Results.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ExpectedValueI : IExpectedValueI
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueI(
            ImmutableList<IExpectedValueIResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IExpectedValueIResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.tIndexElement == tIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
           INullableValueFactory nullableValueFactory,
           It t,
           IΛ Λ)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.tIndexElement.Value,
                    (INullableValue<int>)i.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class xHat : IxHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHat(
            ImmutableList<IxHatResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IxHatResultElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement && x.tIndexElement == tIndexElement)
                .Select(x => x.Value ? 1 : 0)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.rIndexElement.Value,
                    i.tIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}
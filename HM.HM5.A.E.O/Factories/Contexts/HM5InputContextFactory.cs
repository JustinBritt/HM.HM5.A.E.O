namespace HM.HM5.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Classes.Contexts;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM5InputContextFactory : IHM5InputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5InputContextFactory()
        {
        }

        public IHM5InputContext Create(
            ImmutableSortedSet<INullableValue<int>> weekdays,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            ImmutableList<INullableValue<int>> lengthOfStayDays,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> scenarios,
            Duration timeBlockLength,
            ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioLengthOfStayProbabilities,
            INullableValue<int> numberDaysPerWeek,
            ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> surgeonOperatingRoomDayAssignments,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> operatingRoomDayAssignedAvailabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioCumulativeNumberPatients,
            INullableValue<int> maximumNumberRecoveryWardBeds)
        {
            IHM5InputContext context = null;

            try
            {
                context = new HM5InputContext(
                    weekdays,
                    surgicalSpecialties,
                    lengthOfStayDays,
                    operatingRooms,
                    surgeons,
                    planningHorizon,
                    scenarios,
                    timeBlockLength,
                    surgeonScenarioWeightedAverageSurgicalDurations,
                    surgeonLengthOfStayMaximums,
                    surgeonScenarioMaximumNumberPatients,
                    surgeonDayScenarioLengthOfStayProbabilities,
                    numberDaysPerWeek,
                    surgeonOperatingRoomDayAssignments,
                    surgeonOperatingRoomAssignments,
                    operatingRoomDayAssignedAvailabilities,
                    surgeonScenarioMaximumNumberPatientMeans,
                    scenarioProbabilities,
                    surgeonScenarioMaximumNumberPatientStandardDeviations,
                    surgeonDayScenarioCumulativeNumberPatients,
                    maximumNumberRecoveryWardBeds);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}
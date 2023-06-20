namespace HM.HM5.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

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
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            Duration timeBlockLength,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioLengthOfStayProbabilities,
            INullableValue<int> numberDaysPerWeek,
            ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> surgeonOperatingRoomDayAssignments,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> operatingRoomDayAssignedAvailabilities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
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
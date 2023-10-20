namespace HM.HM5.A.E.O.Interfaces.Contexts
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM5OutputContext
    {
        INullableValue<decimal> BestBound { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        INullableValue<decimal> Gap { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        INullableValue<bool> IsFeasible { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> ScenarioNumberPatients { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalTimes { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnderutilizations { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnutilizedTimes { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUtilizedTimes { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedOperatingRooms { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedWeekdays { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalExpectedBedShortages { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }

        RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> OperatingRoomDayDaySwapAssignments { get; }
    }
}
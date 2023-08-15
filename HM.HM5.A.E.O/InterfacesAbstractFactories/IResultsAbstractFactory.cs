﻿namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM5.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM5.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IEBSFactory CreateEBSFactory();

        IExpectedValueIFactory CreateExpectedValueIFactory();

        IExpectedValueΦFactory CreateExpectedValueΦFactory();

        IGapFactory CreateGapFactory();

        IIHatFactory CreateIHatFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        IScenarioNumberPatientsFactory CreateScenarioNumberPatientsFactory();

        IScenarioTotalTimesFactory CreateScenarioTotalTimesFactory();

        IScenarioUnderutilizationsFactory CreateScenarioUnderutilizationsFactory();

        IScenarioUnutilizedTimesFactory CreateScenarioUnutilizedTimesFactory();

        IScenarioUtilizedTimesFactory CreateScenarioUtilizedTimesFactory();

        ISurgeonNumberAssignedOperatingRoomsFactory CreateSurgeonNumberAssignedOperatingRoomsFactory();

        ISurgeonNumberAssignedWeekdaysFactory CreateSurgeonNumberAssignedWeekdaysFactory();

        ISurgeonScenarioNumberPatientsFactory CreateSurgeonScenarioNumberPatientsFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory();

        HM.HM5.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage.ITEBSFactory CreateTEBSFactory();

        HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages.ITEBSFactory CreateTEBSΛFactory();

        IVarianceIFactory CreateVarianceIFactory();

        IVarianceΦFactory CreateVarianceΦFactory();

        IxHatFactory CreatexHatFactory();

        IzFactory CreatezFactory();

        IαFactory CreateαFactory();
    }
}
﻿namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface IResultElementsAbstractFactory
    {
        IEBSResultElementFactory CreateEBSResultElementFactory();

        IExpectedValueIResultElementFactory CreateExpectedValueIResultElementFactory();

        IExpectedValueΦResultElementFactory CreateExpectedValueΦResultElementFactory();

        IIHatResultElementFactory CreateIHatResultElementFactory();

        IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory();

        IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory();

        IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory();

        IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory();

        IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory();

        ISurgeonNumberAssignedWeekdaysResultElementFactory CreateSurgeonNumberAssignedWeekdaysResultElementFactory();

        ISurgeonScenarioNumberPatientsResultElementFactory CreateSurgeonScenarioNumberPatientsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory();

        ITEBSResultElementFactory CreateTEBSΛResultElementFactory();

        IVarianceIResultElementFactory CreateVarianceIResultElementFactory();

        IVarianceΦResultElementFactory CreateVarianceΦResultElementFactory();

        IxHatResultElementFactory CreatexHatResultElementFactory();

        IzResultElementFactory CreatezResultElementFactory();

        IαResultElementFactory CreateαResultElementFactory();
    }
}
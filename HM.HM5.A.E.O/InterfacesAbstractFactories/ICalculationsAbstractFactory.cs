namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ICalculationsAbstractFactory
    {
        IEBSCalculationFactory CreateEBSCalculationFactory();

        IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory();

        IExpectedValueICalculationFactory CreateExpectedValueICalculationFactory();

        IExpectedValueIResultElementCalculationFactory CreateExpectedValueIResultElementCalculationFactory();

        IExpectedValueΦCalculationFactory CreateExpectedValueΦCalculationFactory();

        IExpectedValueΦResultElementCalculationFactory CreateExpectedValueΦResultElementCalculationFactory();

        IS1CalculationFactory CreateS1CalculationFactory();

        IS2CalculationFactory CreateS2CalculationFactory();

        IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory();

        IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory();

        IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory();

        IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory();

        IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory();

        IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory();

        IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory();

        IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory();

        IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory();

        IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgeonNumberAssignedWeekdaysCalculationFactory CreateSurgeonNumberAssignedWeekdaysCalculationFactory();

        ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory();

        ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory();

        ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory();

        HM.HM5.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage.ITEBSCalculationFactory CreateTEBSCalculationFactory();

        HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages.ITEBSCalculationFactory CreateTEBSΛCalculationFactory();

        ITEBSResultElementCalculationFactory CreateTEBSΛResultElementCalculationFactory();

        IVarianceICalculationFactory CreateVarianceICalculationFactory();

        IVarianceIResultElementCalculationFactory CreateVarianceIResultElementCalculationFactory();

        IVarianceΦCalculationFactory CreateVarianceΦCalculationFactory();

        IVarianceΦResultElementCalculationFactory CreateVarianceΦResultElementCalculationFactory();
    }
}
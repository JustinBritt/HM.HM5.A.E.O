namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalTimes
{
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    public interface IScenarioTotalTimesResultElementCalculation
    {
        IScenarioTotalTimesResultElement Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            Isrt srt,
            IH H,
            IxHat xHat);
    }
}
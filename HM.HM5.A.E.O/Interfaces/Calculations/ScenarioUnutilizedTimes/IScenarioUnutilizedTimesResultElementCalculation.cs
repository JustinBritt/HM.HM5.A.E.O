namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesResultElementCalculation
    {
        IScenarioUnutilizedTimesResultElement Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes);
    }
}
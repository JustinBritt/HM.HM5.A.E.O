namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementCalculation
    {
        IScenarioUnderutilizationsResultElement Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes);
    }
}
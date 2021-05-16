namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesResultElementFactory
    {
        IScenarioUnutilizedTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}
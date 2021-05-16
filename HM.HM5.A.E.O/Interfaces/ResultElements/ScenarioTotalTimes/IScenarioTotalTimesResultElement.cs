namespace HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IScenarioTotalTimesResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}
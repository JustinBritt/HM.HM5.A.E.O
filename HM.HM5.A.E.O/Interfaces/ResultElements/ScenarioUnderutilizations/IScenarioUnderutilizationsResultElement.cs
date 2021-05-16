namespace HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnderutilizationsResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}
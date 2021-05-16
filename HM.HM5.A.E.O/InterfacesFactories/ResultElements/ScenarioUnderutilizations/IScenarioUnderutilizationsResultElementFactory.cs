namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementFactory
    {
        IScenarioUnderutilizationsResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}
namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementFactory
    {
        IScenarioNumberPatientsResultElement Create(
            IΛIndexElement ΛIndexElement,
            int value);
    }
}
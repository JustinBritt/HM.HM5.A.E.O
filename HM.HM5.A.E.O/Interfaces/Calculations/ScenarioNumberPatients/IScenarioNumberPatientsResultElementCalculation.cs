namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioNumberPatients
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementCalculation
    {
        IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients);
    }
}
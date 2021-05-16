namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    public interface IIHatResultElementFactory
    {
        IIHatResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}
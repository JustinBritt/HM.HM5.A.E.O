namespace HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioTotalExpectedBedShortages;

    public interface ITEBSFactory
    {
        ITEBS Create(
            ImmutableList<ITEBSResultElement> value);
    }
}
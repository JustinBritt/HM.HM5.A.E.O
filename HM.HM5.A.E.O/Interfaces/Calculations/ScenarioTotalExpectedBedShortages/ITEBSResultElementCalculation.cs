﻿namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;

    public interface ITEBSResultElementCalculation
    {
        ITEBSResultElement Calculate(
            ITEBSResultElementFactory TEBSResultElementFactory,
            IΛIndexElement ΛIndexElement,
            It t,
            IEBS EBS);
    }
}
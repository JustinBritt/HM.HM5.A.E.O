﻿namespace HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages
{
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages;

    public interface ITEBSCalculation
    {
        ITEBS Calculate(
            ITEBSResultElementFactory TEBSResultElementFactory,
            ITEBSFactory TEBSFactory,
            ITEBSResultElementCalculation TEBSResultElementCalculation,
            It t,
            IΛ Λ,
            IEBS EBS);
    }
}
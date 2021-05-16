﻿namespace HM.HM5.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;

    public interface IEBSFactory
    {
        IEBS Create(
            ImmutableList<IEBSResultElement> value);
    }
}
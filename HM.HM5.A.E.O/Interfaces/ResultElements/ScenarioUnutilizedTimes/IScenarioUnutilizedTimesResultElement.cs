﻿namespace HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnutilizedTimesResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}
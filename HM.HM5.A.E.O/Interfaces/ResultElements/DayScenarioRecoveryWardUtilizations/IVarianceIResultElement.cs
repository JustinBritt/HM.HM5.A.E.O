﻿namespace HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IVarianceIResultElement
    {
        ItIndexElement tIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}
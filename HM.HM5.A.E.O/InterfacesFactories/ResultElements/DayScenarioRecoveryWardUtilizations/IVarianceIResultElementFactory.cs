﻿namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;

    public interface IVarianceIResultElementFactory
    {
        IVarianceIResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}
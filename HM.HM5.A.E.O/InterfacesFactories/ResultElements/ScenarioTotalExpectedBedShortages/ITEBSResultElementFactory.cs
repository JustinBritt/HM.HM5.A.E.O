﻿namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;

    public interface ITEBSResultElementFactory
    {
        ITEBSResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}
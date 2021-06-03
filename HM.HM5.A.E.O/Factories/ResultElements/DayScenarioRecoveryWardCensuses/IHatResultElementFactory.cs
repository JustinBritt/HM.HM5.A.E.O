﻿namespace HM.HM5.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardCensuses
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;

    internal sealed class IHatResultElementFactory : IIHatResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatResultElementFactory()
        {
        }

        public IIHatResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IIHatResultElement resultElement = null;

            try
            {
                resultElement = new IHatResultElement(
                    tIndexElement,
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}
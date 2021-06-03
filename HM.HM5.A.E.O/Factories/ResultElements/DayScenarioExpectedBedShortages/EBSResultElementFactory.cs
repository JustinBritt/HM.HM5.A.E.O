﻿namespace HM.HM5.A.E.O.Factories.ResultElements.DayScenarioExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;

    internal sealed class EBSResultElementFactory : IEBSResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementFactory()
        {
        }

        public IEBSResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IEBSResultElement resultElement = null;

            try
            {
                resultElement = new EBSResultElement(
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
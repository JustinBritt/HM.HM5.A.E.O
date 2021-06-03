﻿namespace HM.HM5.A.E.O.Factories.Calculations.DayScenarioExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;

    internal sealed class EBSCalculationFactory : IEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculationFactory()
        {
        }

        public IEBSCalculation Create()
        {
            IEBSCalculation calculation = null;

            try
            {
                calculation = new EBSCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioTotalExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSCalculationFactory : ITEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculationFactory()
        {
        }

        public ITEBSCalculation Create()
        {
            ITEBSCalculation calculation = null;

            try
            {
                calculation = new TEBSCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
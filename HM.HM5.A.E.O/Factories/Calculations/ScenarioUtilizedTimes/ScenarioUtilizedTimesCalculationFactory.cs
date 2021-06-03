﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioUtilizedTimes
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesCalculationFactory : IScenarioUtilizedTimesCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesCalculationFactory()
        {
        }

        public IScenarioUtilizedTimesCalculation Create()
        {
            IScenarioUtilizedTimesCalculation calculation = null;

            try
            {
                calculation = new ScenarioUtilizedTimesCalculation();
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
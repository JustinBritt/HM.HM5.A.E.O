﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioTotalTimes
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementCalculationFactory : IScenarioTotalTimesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementCalculationFactory()
        {
        }

        public IScenarioTotalTimesResultElementCalculation Create()
        {
            IScenarioTotalTimesResultElementCalculation calculation = null;

            try
            {
                calculation = new ScenarioTotalTimesResultElementCalculation();
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
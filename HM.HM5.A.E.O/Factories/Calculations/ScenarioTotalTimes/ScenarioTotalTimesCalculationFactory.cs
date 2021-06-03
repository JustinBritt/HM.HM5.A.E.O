﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioTotalTimes
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesCalculationFactory : IScenarioTotalTimesCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesCalculationFactory()
        {
        }

        public IScenarioTotalTimesCalculation Create()
        {
            IScenarioTotalTimesCalculation calculation = null;

            try
            {
                calculation = new ScenarioTotalTimesCalculation();
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
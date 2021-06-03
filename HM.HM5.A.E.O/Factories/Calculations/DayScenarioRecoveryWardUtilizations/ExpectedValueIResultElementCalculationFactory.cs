﻿namespace HM.HM5.A.E.O.Factories.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueIResultElementCalculationFactory : IExpectedValueIResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueIResultElementCalculationFactory()
        {
        }

        public IExpectedValueIResultElementCalculation Create()
        {
            IExpectedValueIResultElementCalculation calculation = null;

            try
            {
                calculation = new ExpectedValueIResultElementCalculation();
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
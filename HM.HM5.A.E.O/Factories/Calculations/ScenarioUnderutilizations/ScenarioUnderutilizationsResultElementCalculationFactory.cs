﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioUnderutilizations
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElementCalculationFactory : IScenarioUnderutilizationsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElementCalculationFactory()
        {
        }

        public IScenarioUnderutilizationsResultElementCalculation Create()
        {
            IScenarioUnderutilizationsResultElementCalculation calculation = null;

            try
            {
                calculation = new ScenarioUnderutilizationsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Factories.Calculations.ScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.ScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsCalculationFactory : IScenarioNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsCalculationFactory()
        {
        }

        public IScenarioNumberPatientsCalculation Create()
        {
            IScenarioNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new ScenarioNumberPatientsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
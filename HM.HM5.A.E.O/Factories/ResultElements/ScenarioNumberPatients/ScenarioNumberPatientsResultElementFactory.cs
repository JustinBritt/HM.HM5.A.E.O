﻿namespace HM.HM5.A.E.O.Factories.ResultElements.ScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementFactory : IScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementFactory()
        {
        }

        public IScenarioNumberPatientsResultElement Create(
            IΛIndexElement ΛIndexElement,
            int value)
        {
            IScenarioNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioNumberPatientsResultElement(
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}
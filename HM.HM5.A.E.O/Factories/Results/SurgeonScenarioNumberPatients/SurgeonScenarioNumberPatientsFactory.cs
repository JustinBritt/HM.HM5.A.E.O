﻿namespace HM.HM5.A.E.O.Factories.Results.SurgeonScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsFactory : ISurgeonScenarioNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsFactory()
        {
        }

        public ISurgeonScenarioNumberPatients Create(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value)
        {
            ISurgeonScenarioNumberPatients result = null;

            try
            {
                result = new SurgeonScenarioNumberPatients(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Factories.Results.ScenarioUtilizedTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesFactory : IScenarioUtilizedTimesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesFactory()
        {
        }

        public IScenarioUtilizedTimes Create(
            ImmutableList<IScenarioUtilizedTimesResultElement> value)
        {
            IScenarioUtilizedTimes result = null;

            try
            {
                result = new ScenarioUtilizedTimes(
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
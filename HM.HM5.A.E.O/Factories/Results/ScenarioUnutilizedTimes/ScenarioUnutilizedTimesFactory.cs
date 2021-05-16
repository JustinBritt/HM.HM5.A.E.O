﻿namespace HM.HM5.A.E.O.Factories.Results.ScenarioUnutilizedTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesFactory : IScenarioUnutilizedTimesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesFactory()
        {
        }

        public IScenarioUnutilizedTimes Create(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value)
        {
            IScenarioUnutilizedTimes result = null;

            try
            {
                result = new ScenarioUnutilizedTimes(
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
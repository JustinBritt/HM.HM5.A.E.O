﻿namespace HM.HM5.A.E.O.Factories.Results.DayScenarioExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;

    internal sealed class EBSFactory : IEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSFactory()
        {
        }

        public IEBS Create(
            ImmutableList<IEBSResultElement> value)
        {
            IEBS result = null;

            try
            {
                result = new EBS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Factories.Results.OverallWallTime
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.OverallWallTime;
    using HM.HM5.A.E.O.Interfaces.Results.OverallWallTime;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OverallWallTime;

    internal sealed class OverallWallTimeFactory : IOverallWallTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OverallWallTimeFactory()
        {
        }

        public IOverallWallTime Create(
            TimeSpan value)
        {
            IOverallWallTime result = null;

            try
            {
                result = new OverallWallTime(
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
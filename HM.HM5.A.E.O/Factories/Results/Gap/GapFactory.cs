﻿namespace HM.HM5.A.E.O.Factories.Results.Gap
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.Gap;
    using HM.HM5.A.E.O.Interfaces.Results.Gap;
    using HM.HM5.A.E.O.InterfacesFactories.Results.Gap;

    internal sealed class GapFactory : IGapFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GapFactory()
        {
        }

        public IGap Create(
            decimal value)
        {
            IGap result = null;

            try
            {
                result = new Gap(
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
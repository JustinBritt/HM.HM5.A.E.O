﻿namespace HM.HM5.A.E.O.Factories.Parameters.TimeBlockLength
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Classes.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;

    internal sealed class HFactory : IHFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HFactory()
        {
        }

        public IH Create(
            Duration value)
        {
            IH parameter = null;

            try
            {
                parameter = new H(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}
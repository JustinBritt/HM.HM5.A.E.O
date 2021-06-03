﻿namespace HM.HM5.A.E.O.Factories.Parameters.SurgeonLengthOfStayMaximums
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;

    internal sealed class LFactory : ILFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LFactory()
        {
        }

        public IL Create(
            ImmutableList<ILParameterElement> value)
        {
            IL parameter = null;

            try
            {
                parameter = new L(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
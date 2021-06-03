﻿namespace HM.HM5.A.E.O.Factories.Results.SurgeonNumberAssignedWeekdays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysFactory : ISurgeonNumberAssignedWeekdaysFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysFactory()
        {
        }

        public ISurgeonNumberAssignedWeekdays Create(
            ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> value)
        {
            ISurgeonNumberAssignedWeekdays result = null;

            try
            {
                result = new SurgeonNumberAssignedWeekdays(
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
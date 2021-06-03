﻿namespace HM.HM5.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory : ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation Create()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}
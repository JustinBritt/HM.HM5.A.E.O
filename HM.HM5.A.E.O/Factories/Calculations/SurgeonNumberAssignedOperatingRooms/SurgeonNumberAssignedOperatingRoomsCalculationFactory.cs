﻿namespace HM.HM5.A.E.O.Factories.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsCalculationFactory : ISurgeonNumberAssignedOperatingRoomsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsCalculationFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsCalculation Create()
        {
            ISurgeonNumberAssignedOperatingRoomsCalculation calculation = null;

            try
            {
                calculation = new SurgeonNumberAssignedOperatingRoomsCalculation();
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
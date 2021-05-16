﻿namespace HM.HM5.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsFactory : ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> value)
        {
            ISurgicalSpecialtyNumberAssignedOperatingRooms result = null;

            try
            {
                result = new SurgicalSpecialtyNumberAssignedOperatingRooms(
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
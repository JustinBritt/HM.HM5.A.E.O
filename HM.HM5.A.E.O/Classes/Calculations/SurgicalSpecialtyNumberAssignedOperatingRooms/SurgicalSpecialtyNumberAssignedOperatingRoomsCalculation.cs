﻿namespace HM.HM5.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsCalculation : ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            IΔ Δ,
            IxHat xHat)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsFactory.Create(
                Δ.Value
                .Select(i => surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
                    i,
                    xHat))
                .ToImmutableList());
        }
    }
}
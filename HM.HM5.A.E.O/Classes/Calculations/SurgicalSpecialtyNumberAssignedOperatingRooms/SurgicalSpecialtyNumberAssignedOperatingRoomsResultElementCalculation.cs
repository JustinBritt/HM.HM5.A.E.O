﻿namespace HM.HM5.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation : ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            IΔParameterElement ΔParameterElement,
            IxHat xHat)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                ΔParameterElement.Value.SelectMany(a => xHat.GetElementsAsImmutableList().Where(i => i.sIndexElement == a && i.Value).Select(w => w.rIndexElement)).Distinct().Count());
        }
    }
}
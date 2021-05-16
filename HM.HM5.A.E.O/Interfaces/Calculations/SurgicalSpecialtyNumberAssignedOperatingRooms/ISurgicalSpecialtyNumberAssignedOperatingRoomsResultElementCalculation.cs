namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation
    {
        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            IΔParameterElement ΔParameterElement,
            IxHat xHat);
    }
}
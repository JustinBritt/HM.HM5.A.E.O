namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;

    public interface ISurgeonNumberAssignedOperatingRoomsCalculation
    {
        ISurgeonNumberAssignedOperatingRooms Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonNumberAssignedOperatingRoomsFactory surgeonNumberAssignedOperatingRoomsFactory,
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation surgeonNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            IxHat xHat);
    }
}
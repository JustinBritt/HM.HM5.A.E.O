namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;

    public interface ISurgeonNumberAssignedOperatingRoomsResultElementCalculation
    {
        ISurgeonNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            IxHat xHat);
    }
}
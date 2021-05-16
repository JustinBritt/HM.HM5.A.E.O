namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory
    {
        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Create(
            IjIndexElement jIndexElement,
            int value);
    }
}
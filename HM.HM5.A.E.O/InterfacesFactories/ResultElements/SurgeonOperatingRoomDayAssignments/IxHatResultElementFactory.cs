namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxHatResultElementFactory
    {
        IxHatResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value);
    }
}
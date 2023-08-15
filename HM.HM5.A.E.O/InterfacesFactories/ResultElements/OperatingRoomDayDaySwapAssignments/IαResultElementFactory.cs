namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;

    public interface IαResultElementFactory
    {
        IαResultElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            bool value);
    }
}
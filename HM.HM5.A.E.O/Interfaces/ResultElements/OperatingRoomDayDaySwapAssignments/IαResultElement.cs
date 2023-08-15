namespace HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IαResultElement
    {
        IrIndexElement rIndexElement { get; }

        Id1IndexElement d1IndexElement { get; }

        Id2IndexElement d2IndexElement { get; }

        bool Value { get; }
    }
}
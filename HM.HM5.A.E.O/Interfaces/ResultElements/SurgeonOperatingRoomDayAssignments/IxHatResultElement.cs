namespace HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IxHatResultElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        bool Value { get; }
    }
}
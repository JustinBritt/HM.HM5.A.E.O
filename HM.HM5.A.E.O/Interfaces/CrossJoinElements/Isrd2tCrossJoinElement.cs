namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Isrd2tCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        Id2IndexElement d2IndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}
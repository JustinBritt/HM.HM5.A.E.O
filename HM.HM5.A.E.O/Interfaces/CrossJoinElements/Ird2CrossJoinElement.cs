namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Ird2CrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        Id2IndexElement d2IndexElement { get; }
    }
}
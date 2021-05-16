namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Ird1CrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        Id1IndexElement d1IndexElement { get; }
    }
}
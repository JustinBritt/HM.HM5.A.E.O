namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Isrd2CrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        Id2IndexElement d2IndexElement { get; }
    }
}
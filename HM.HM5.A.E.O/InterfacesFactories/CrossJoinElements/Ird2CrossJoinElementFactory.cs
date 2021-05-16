namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Ird2CrossJoinElementFactory
    {
        Ird2CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement);
    }
}
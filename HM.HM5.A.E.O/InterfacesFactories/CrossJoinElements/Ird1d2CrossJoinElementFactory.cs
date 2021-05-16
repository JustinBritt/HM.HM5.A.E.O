namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Ird1d2CrossJoinElementFactory
    {
        Ird1d2CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);
    }
}
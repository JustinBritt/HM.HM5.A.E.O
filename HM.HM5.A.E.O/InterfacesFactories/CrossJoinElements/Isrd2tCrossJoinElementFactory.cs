namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Isrd2tCrossJoinElementFactory
    {
        Isrd2tCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement,
            ItIndexElement tIndexElement);
    }
}
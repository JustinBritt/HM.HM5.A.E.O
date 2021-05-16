namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Isrd2CrossJoinElementFactory
    {
        Isrd2CrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement);
    }
}
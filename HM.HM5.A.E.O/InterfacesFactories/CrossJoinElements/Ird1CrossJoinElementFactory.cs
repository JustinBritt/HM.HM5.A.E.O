namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Ird1CrossJoinElementFactory
    {
        Ird1CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement);
    }
}
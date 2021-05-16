namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        Id1IndexElementFactory Created1IndexElementFactory();

        Id2IndexElementFactory Created2IndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IlIndexElementFactory CreatelIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        ItIndexElementFactory CreatetIndexElementFactory();

        IΛIndexElementFactory CreateΛIndexElementFactory();
    }
}
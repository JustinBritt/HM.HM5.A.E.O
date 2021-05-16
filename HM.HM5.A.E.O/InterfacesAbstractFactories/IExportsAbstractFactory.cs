namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IHM5ExportFactory CreateHM5ExportFactory();
    }
}
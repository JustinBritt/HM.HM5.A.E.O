namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IHM5ModelFactory CreateHM5ModelFactory();
    }
}
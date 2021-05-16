namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IHM5InputContextFactory CreateHM5InputContextFactory();

        IHM5OutputContextFactory CreateHM5OutputContextFactory();
    }
}
namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Configurations;

    public interface IConfigurationsAbstractFactory
    {
        IHM5ConfigurationFactory CreateHM5ConfigurationFactory();
    }
}
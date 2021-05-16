namespace HM.HM5.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM5.A.E.O.Interfaces.Configurations;

    public interface IHM5ConfigurationFactory
    {
        IHM5Configuration Create(
            Configuration configuration);
    }
}
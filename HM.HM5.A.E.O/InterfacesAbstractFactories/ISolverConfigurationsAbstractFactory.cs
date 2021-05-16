namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.SolverConfigurations;

    public interface ISolverConfigurationsAbstractFactory
    {
        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}
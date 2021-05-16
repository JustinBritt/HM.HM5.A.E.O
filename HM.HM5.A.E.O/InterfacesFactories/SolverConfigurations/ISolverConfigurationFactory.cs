namespace HM.HM5.A.E.O.InterfacesFactories.SolverConfigurations
{
    using HM.HM5.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}
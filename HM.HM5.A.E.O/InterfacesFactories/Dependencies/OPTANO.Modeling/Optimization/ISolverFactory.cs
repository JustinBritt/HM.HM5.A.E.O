namespace HM.HM5.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization.Interfaces;

    using HM.HM5.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverFactory
    {
        ISolver Create(
            ISolverConfiguration solverConfiguration);
    }
}
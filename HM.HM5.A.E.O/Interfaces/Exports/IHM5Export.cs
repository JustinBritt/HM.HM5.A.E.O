namespace HM.HM5.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;

    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Configurations;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.SolverConfigurations;

    public interface IHM5Export
    {
        Task<IHM5OutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM5Configuration HM5Configuration,
            IHM5InputContext HM5InputContext,
            ISolverConfiguration solverConfiguration);
    }
}
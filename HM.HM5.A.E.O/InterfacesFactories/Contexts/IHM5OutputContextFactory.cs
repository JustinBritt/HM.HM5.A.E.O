namespace HM.HM5.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.Models;

    public interface IHM5OutputContextFactory
    {
        IHM5OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM5Model HM5Model,
            Solution solution);
    }
}
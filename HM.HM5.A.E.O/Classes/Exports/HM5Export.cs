namespace HM.HM5.A.E.O.Classes.Exports
{
    using System.Threading.Tasks;

    using log4net;

    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Configurations;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.Exports;
    using HM.HM5.A.E.O.Interfaces.SolverConfigurations;

    public sealed class HM5Export : IHM5Export
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5Export()
        {
        }

        public Task<IHM5OutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM5Configuration HM5Configuration,
            IHM5InputContext HM5InputContext,
            ISolverConfiguration solverConfiguration)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateHM5SolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                HM5Configuration,
                HM5InputContext,
                solverConfiguration);
        }
    }
}
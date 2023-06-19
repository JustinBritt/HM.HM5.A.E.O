namespace HM.HM5.A.E.O.Factories.Models
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Models;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.Models;
    using HM.HM5.A.E.O.InterfacesFactories.Models;

    internal sealed class HM5ModelFactory : IHM5ModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5ModelFactory()
        {
        }

        public IHM5Model Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM5InputContext HM5InputContext)
        {
            IHM5Model model = null;

            try
            {
                model = new HM5Model(
                    calculationsAbstractFactory,
                    comparersAbstractFactory,
                    constraintElementsAbstractFactory,
                    constraintsAbstractFactory,
                    crossJoinElementsAbstractFactory,
                    crossJoinsAbstractFactory,
                    dependenciesAbstractFactory,
                    indexElementsAbstractFactory,
                    indicesAbstractFactory,
                    objectiveFunctionsAbstractFactory,
                    parameterElementsAbstractFactory,
                    parametersAbstractFactory,
                    variablesAbstractFactory,
                    HM5InputContext);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return model;
        }
    }
}
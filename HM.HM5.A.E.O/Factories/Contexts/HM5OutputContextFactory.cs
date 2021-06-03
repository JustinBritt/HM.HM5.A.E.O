namespace HM.HM5.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Classes.Contexts;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.Models;
    using HM.HM5.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM5OutputContextFactory : IHM5OutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5OutputContextFactory()
        {
        }

        public IHM5OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM5Model HM5Model,
            Solution solution)
        {
            IHM5OutputContext context = null;

            try
            {
                context = new HM5OutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    HM5Model,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}
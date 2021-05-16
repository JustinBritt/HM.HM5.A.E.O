namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Contexts;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Contexts;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IHM5InputContextFactory CreateHM5InputContextFactory()
        {
            IHM5InputContextFactory factory = null;

            try
            {
                factory = new HM5InputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IHM5OutputContextFactory CreateHM5OutputContextFactory()
        {
            IHM5OutputContextFactory factory = null;

            try
            {
                factory = new HM5OutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
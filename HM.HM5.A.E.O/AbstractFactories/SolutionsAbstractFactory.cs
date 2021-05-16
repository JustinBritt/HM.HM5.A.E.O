namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Solutions;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Solutions;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public IHM5SolutionFactory CreateHM5SolutionFactory()
        {
            IHM5SolutionFactory factory = null;

            try
            {
                factory = new HM5SolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Exports;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Exports;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExportsAbstractFactory()
        {
        }

        public IHM5ExportFactory CreateHM5ExportFactory()
        {
            IHM5ExportFactory factory = null;

            try
            {
                factory = new HM5ExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
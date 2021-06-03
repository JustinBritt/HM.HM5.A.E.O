namespace HM.HM5.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Exports;
    using HM.HM5.A.E.O.Interfaces.Exports;
    using HM.HM5.A.E.O.InterfacesFactories.Exports;

    internal sealed class HM5ExportFactory : IHM5ExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5ExportFactory()
        {
        }

        public IHM5Export Create()
        {
            IHM5Export export = null;

            try
            {
                export = new HM5Export();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}
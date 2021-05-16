namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Configurations;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Configurations;

    internal sealed class ConfigurationsAbstractFactory : IConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationsAbstractFactory()
        {
        }

        public IHM5ConfigurationFactory CreateHM5ConfigurationFactory()
        {
            IHM5ConfigurationFactory factory = null;

            try
            {
                factory = new HM5ConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
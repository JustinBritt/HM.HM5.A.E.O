namespace HM.HM5.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM5.A.E.O.Classes.Configurations;
    using HM.HM5.A.E.O.Interfaces.Configurations;
    using HM.HM5.A.E.O.InterfacesFactories.Configurations;

    internal sealed class HM5ConfigurationFactory : IHM5ConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5ConfigurationFactory()
        {
        }

        public IHM5Configuration Create(
            Configuration configuration)
        {
            IHM5Configuration HM5Configuration = null;

            try
            {
                HM5Configuration = new HM5Configuration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return HM5Configuration;
        }
    }
}
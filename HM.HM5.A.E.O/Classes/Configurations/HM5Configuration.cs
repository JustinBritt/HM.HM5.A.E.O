namespace HM.HM5.A.E.O.Classes.Configurations
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM5.A.E.O.Interfaces.Configurations;

    internal sealed class HM5Configuration : IHM5Configuration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5Configuration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}
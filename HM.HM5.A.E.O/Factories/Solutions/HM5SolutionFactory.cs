namespace HM.HM5.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Solutions;
    using HM.HM5.A.E.O.Interfaces.Solutions;
    using HM.HM5.A.E.O.InterfacesFactories.Solutions;

    internal sealed class HM5SolutionFactory : IHM5SolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5SolutionFactory()
        {
        }

        public IHM5Solution Create()
        {
            IHM5Solution solution = null;

            try
            {
                solution = new HM5Solution();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solution;
        }
    }
}
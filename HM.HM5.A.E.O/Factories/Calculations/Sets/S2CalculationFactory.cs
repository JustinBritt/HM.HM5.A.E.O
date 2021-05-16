namespace HM.HM5.A.E.O.Factories.Calculations.Sets
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.Calculations.Sets;
    using HM.HM5.A.E.O.Interfaces.Calculations.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Calculations.Sets;

    internal sealed class S2CalculationFactory : IS2CalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2CalculationFactory()
        {
        }

        public IS2Calculation Create()
        {
            IS2Calculation calculation = null;

            try
            {
                calculation = new S2Calculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}
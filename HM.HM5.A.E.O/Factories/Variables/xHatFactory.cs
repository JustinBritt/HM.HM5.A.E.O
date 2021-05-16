namespace HM.HM5.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Classes.Variables;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.Variables;

    internal sealed class xHatFactory : IxHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatFactory()
        {
        }

        public IxHat Create(
            VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> value)
        {
            IxHat variable = null;

            try
            {
                variable = new xHat(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}
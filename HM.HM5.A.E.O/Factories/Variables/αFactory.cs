namespace HM.HM5.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Classes.Variables;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.Variables;

    internal sealed class αFactory : IαFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αFactory()
        {
        }

        public Iα Create(
            VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> value)
        {
            Iα variable = null;

            try
            {
                variable = new α(
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
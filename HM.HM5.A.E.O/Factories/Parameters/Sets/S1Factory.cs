namespace HM.HM5.A.E.O.Factories.Parameters.Sets
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    internal sealed class S1Factory : IS1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1Factory()
        {
        }

        public IS1 Create(
            ImmutableList<IS1ParameterElement> value)
        {
            IS1 parameter = null;

            try
            {
                parameter = new S1(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}
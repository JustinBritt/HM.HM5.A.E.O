namespace HM.HM5.A.E.O.Factories.Parameters.Sets
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    internal sealed class S2Factory : IS2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2Factory()
        {
        }

        public IS2 Create(
            ImmutableList<IS2ParameterElement> value)
        {
            IS2 parameter = null;

            try
            {
                parameter = new S2(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
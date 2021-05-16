namespace HM.HM5.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Indices;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.Indices;

    internal sealed class d2Factory : Id2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Factory()
        {
        }

        public Id2 Create(
            ImmutableList<Id2IndexElement> value)
        {
            Id2 index = null;

            try
            {
                index = new d2(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return index;
        }
    }
}
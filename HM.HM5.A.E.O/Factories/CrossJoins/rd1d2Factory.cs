namespace HM.HM5.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class rd1d2Factory : Ird1d2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1d2Factory()
        {
        }

        public Ird1d2 Create(
            ImmutableList<Ird1d2CrossJoinElement> value)
        {
            Ird1d2 crossJoin = null;

            try
            {
                crossJoin = new rd1d2(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoin;
        }
    }
}
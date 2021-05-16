namespace HM.HM5.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class rd2Factory : Ird2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd2Factory()
        {
        }

        public Ird2 Create(
            ImmutableList<Ird2CrossJoinElement> value)
        {
            Ird2 crossJoin = null;

            try
            {
                crossJoin = new rd2(
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
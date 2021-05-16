﻿namespace HM.HM5.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class stFactory : IstFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public stFactory()
        {
        }

        public Ist Create(
            ImmutableList<IstCrossJoinElement> value)
        {
            Ist crossJoin = null;

            try
            {
                crossJoin = new st(
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
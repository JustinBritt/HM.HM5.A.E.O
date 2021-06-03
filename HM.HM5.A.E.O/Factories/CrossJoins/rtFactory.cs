﻿namespace HM.HM5.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class rtFactory : IrtFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rtFactory()
        {
        }

        public Irt Create(
            ImmutableList<IrtCrossJoinElement> value)
        {
            Irt crossJoin = null;

            try
            {
                crossJoin = new rt(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}
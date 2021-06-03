﻿namespace HM.HM5.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class tΛFactory : ItΛFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tΛFactory()
        {
        }

        public ItΛ Create(
            ImmutableList<ItΛCrossJoinElement> value)
        {
            ItΛ crossJoin = null;

            try
            {
                crossJoin = new tΛ(
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
﻿namespace HM.HM5.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Constraints;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;
    using HM.HM5.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints2Factory : IConstraints2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2Factory()
        {
        }

        public IConstraints2 Create(
            ImmutableList<IConstraints2ConstraintElement> value)
        {
            IConstraints2 constraint = null;

            try
            {
                constraint = new Constraints2(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints1 : IConstraints1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1(
            ImmutableList<IConstraints1ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints1ConstraintElement> Value { get; }
    }
}
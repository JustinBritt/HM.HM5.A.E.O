﻿namespace HM.HM5.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints6 : IConstraints6
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6(
            ImmutableList<IConstraints6ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints6ConstraintElement> Value { get; }
    }
}
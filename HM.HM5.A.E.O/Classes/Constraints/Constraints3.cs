﻿namespace HM.HM5.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints3 : IConstraints3
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3(
            ImmutableList<IConstraints3ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints3ConstraintElement> Value { get; }
    }
}
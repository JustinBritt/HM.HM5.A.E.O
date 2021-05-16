namespace HM.HM5.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints9 : IConstraints9
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9(
            ImmutableList<IConstraints9ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints9ConstraintElement> Value { get; }
    }
}
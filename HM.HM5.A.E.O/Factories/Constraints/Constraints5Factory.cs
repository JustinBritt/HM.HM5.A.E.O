namespace HM.HM5.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Constraints;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;
    using HM.HM5.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints5Factory : IConstraints5Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5Factory()
        {
        }

        public IConstraints5 Create(
            ImmutableList<IConstraints5ConstraintElement> value)
        {
            IConstraints5 constraint = null;

            try
            {
                constraint = new Constraints5(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}
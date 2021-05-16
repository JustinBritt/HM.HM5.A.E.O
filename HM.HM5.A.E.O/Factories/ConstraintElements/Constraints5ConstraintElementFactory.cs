namespace HM.HM5.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5ConstraintElementFactory : IConstraints5ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5ConstraintElementFactory()
        {
        }

        public IConstraints5ConstraintElement Create(
            Id1IndexElement d1IndexElement,
            IrIndexElement rIndexElement,
            Id2 d2,
            Iα α)
        {
            IConstraints5ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5ConstraintElement(
                    d1IndexElement,
                    rIndexElement,
                    d2,
                    α);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}
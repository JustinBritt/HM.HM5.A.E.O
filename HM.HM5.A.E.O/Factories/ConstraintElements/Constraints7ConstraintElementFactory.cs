namespace HM.HM5.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints7ConstraintElementFactory : IConstraints7ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints7ConstraintElementFactory()
        {
        }

        public IConstraints7ConstraintElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            Iα α)
        {
            IConstraints7ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints7ConstraintElement(
                    rIndexElement,
                    d1IndexElement,
                    d2IndexElement,
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
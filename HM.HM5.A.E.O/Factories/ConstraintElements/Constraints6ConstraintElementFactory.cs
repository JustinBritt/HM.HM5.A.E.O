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

    internal sealed class Constraints6ConstraintElementFactory : IConstraints6ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElementFactory()
        {
        }

        public IConstraints6ConstraintElement Create(
            Id2IndexElement d2IndexElement,
            IrIndexElement rIndexElement,
            Id1 d1,
            Iα α)
        {
            IConstraints6ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints6ConstraintElement(
                    d2IndexElement,
                    rIndexElement,
                    d1,
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
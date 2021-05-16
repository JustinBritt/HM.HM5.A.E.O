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

    internal sealed class Constraints1ConstraintElementFactory : IConstraints1ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElementFactory()
        {
        }

        public IConstraints1ConstraintElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            IxHat xHat,
            Iz z)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    sIndexElement,
                    tIndexElement,
                    r,
                    xHat,
                    z);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}
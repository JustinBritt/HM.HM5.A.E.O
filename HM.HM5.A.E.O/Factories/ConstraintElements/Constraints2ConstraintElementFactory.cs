namespace HM.HM5.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints2ConstraintElementFactory : IConstraints2ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElementFactory()
        {
        }

        public IConstraints2ConstraintElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Iγ γ,
            IxHat xHat)
        {
            IConstraints2ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints2ConstraintElement(
                    rIndexElement,
                    tIndexElement,
                    s,
                    γ,
                    xHat);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}
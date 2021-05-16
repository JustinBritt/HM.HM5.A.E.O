namespace HM.HM5.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints8ConstraintElementFactory : IConstraints8ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8ConstraintElementFactory()
        {
        }

        public IConstraints8ConstraintElement Create(
            Id2IndexElement d2IndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Id1 d1,
            It t,
            Ix x,
            IxHat xHat,
            Iα α)
        {
            IConstraints8ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints8ConstraintElement(
                    d2IndexElement,
                    rIndexElement,
                    sIndexElement,
                    tIndexElement,
                    d1,
                    t,
                    x,
                    xHat,
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
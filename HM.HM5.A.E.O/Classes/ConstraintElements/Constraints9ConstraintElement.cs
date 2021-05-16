namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints9ConstraintElement : IConstraints9ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ix x,
            IxHat xHat)
        {
            Expression LHS = xHat.Value[sIndexElement, rIndexElement, tIndexElement];

            int RHS = x.GetElementAtAsint(
                sIndexElement,
                rIndexElement,
                tIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
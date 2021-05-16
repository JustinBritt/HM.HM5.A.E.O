namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iy y,
            IxHat xHat)
        {
            Expression LHS = xHat.Value[sIndexElement, rIndexElement, tIndexElement];

            int RHS = y.GetElementAtAsint(
                sIndexElement,
                rIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}
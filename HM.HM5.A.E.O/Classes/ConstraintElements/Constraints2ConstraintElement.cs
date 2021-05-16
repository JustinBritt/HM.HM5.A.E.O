namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints2ConstraintElement : IConstraints2ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Iγ γ,
            IxHat xHat)
        {
            Expression LHS = Expression.Sum(
                s.Value
                .Select(
                    y => xHat.Value[y, rIndexElement, tIndexElement]));

            int RHS = γ.GetElementAtAsint(
                rIndexElement,
                tIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}
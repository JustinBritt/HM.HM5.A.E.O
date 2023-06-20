namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints8ConstraintElement : IConstraints8ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8ConstraintElement(
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
            Expression LHS = xHat.Value[
                sIndexElement,
                rIndexElement,
                t.GetElementAt(
                        tIndexElement.Key + d2IndexElement.Value.Value.Value)];

            Expression RHS = Expression.Sum(
                d1.Value.Values
                .Select(
                   y => x.GetElementAtAsint(
                       sIndexElement,
                       rIndexElement,
                       t.GetElementAt(
                               tIndexElement.Key + y.Value.Value.Value))
                               *
                               α.Value[rIndexElement, y, d2IndexElement]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
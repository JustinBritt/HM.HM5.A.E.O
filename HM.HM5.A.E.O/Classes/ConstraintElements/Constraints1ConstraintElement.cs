namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1ConstraintElement : IConstraints1ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElement(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            IxHat xHat,
            Iz z)
        {
            Expression LHS = Expression.Sum(
                r.Value.Values
                .Select(
                   y => xHat.Value[sIndexElement, y, tIndexElement]));

            Expression RHS = z.Value[sIndexElement, tIndexElement];

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
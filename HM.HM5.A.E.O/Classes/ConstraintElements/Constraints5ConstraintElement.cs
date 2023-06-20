namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5ConstraintElement : IConstraints5ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5ConstraintElement(
            Id1IndexElement d1IndexElement,
            IrIndexElement rIndexElement,
            Id2 d2,
            Iα α)
        {
            Expression LHS = Expression.Sum(
                d2.Value.Values
                .Select(
                   y => α.Value[rIndexElement, d1IndexElement, y]));

            int RHS = 1;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
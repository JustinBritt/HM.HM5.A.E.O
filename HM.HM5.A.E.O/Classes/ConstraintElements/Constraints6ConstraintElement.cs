namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints6ConstraintElement : IConstraints6ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElement(
            Id2IndexElement d2IndexElement,
            IrIndexElement rIndexElement,
            Id1 d1,
            Iα α)
        {            
            Expression LHS = Expression.Sum(
                d1.Value
                .Select(
                   y => α.Value[rIndexElement, y, d2IndexElement]));

            int RHS = 1;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
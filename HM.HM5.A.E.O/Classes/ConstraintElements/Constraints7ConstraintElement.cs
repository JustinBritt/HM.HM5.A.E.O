namespace HM.HM5.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class Constraints7ConstraintElement : IConstraints7ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints7ConstraintElement(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            Iα α)
        {
            Expression LHS = α.Value[rIndexElement, d1IndexElement, d2IndexElement];

            int RHS = 0;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}
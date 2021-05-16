namespace HM.HM5.A.E.O.Classes.Parameters.Sets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;

    internal sealed class S2 : IS2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2(
            ImmutableList<IS2ParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IS2ParameterElement> Value { get; }

        public bool IsThereElementAt(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            int count = this.Value
                .Where(x => x.rIndexElement == rIndexElement && x.d1IndexElement == d1IndexElement && x.d2IndexElement == d2IndexElement)
                .Distinct()
                .Count();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
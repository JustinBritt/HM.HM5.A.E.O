namespace HM.HM5.A.E.O.Classes.Parameters.Sets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;

    internal sealed class S1 : IS1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1(
            ImmutableList<IS1ParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IS1ParameterElement> Value { get; }

        public bool IsThereElementAt(
            IrIndexElement rIndexElement)
        {
            int count = this.Value
                .Where(x => x.rIndexElement == rIndexElement)
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
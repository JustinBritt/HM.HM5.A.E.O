namespace HM.HM5.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    internal sealed class d1 : Id1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1(
            ImmutableList<Id1IndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id1IndexElement> Value { get; }

        public Id1IndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}
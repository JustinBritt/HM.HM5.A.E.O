namespace HM.HM5.A.E.O.Classes.ParameterElements.Sets
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    internal sealed class S2ParameterElement : IS2ParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2ParameterElement(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.d1IndexElement = d1IndexElement;

            this.d2IndexElement = d2IndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public Id1IndexElement d1IndexElement { get; }

        public Id2IndexElement d2IndexElement { get; }
    }
}
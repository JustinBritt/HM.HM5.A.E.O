namespace HM.HM5.A.E.O.Classes.ParameterElements.Sets
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    internal sealed class S1ParameterElement : IS1ParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1ParameterElement(
            IrIndexElement rIndexElement)
        {
            this.rIndexElement = rIndexElement;
        }

        public IrIndexElement rIndexElement { get; }
    }
}
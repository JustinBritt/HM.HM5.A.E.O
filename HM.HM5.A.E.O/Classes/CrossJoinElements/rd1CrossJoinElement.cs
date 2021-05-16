namespace HM.HM5.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class rd1CrossJoinElement : Ird1CrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1CrossJoinElement(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.d1IndexElement = d1IndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public Id1IndexElement d1IndexElement { get; }
    }
}
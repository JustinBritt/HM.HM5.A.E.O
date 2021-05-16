namespace HM.HM5.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class rd1d2CrossJoinElement : Ird1d2CrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1d2CrossJoinElement(
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
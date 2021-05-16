namespace HM.HM5.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class rd2CrossJoinElement : Ird2CrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd2CrossJoinElement(
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.d2IndexElement = d2IndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public Id2IndexElement d2IndexElement { get; }
    }
}
namespace HM.HM5.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class srd2tCrossJoinElement : Isrd2tCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srd2tCrossJoinElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement,
            ItIndexElement tIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.d2IndexElement = d2IndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public Id2IndexElement d2IndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}
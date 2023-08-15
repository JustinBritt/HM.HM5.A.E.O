namespace HM.HM5.A.E.O.Classes.ResultElements.OperatingRoomDayDaySwapAssignments
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;

    internal sealed class αResultElement : IαResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αResultElement(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            bool value)
        {
            this.rIndexElement = rIndexElement;

            this.d1IndexElement = d1IndexElement;

            this.d2IndexElement = d2IndexElement;

            this.Value = value;
        }

        public IrIndexElement rIndexElement { get; }

        public Id1IndexElement d1IndexElement { get; }

        public Id2IndexElement d2IndexElement { get; }

        public bool Value { get; }
    }
}
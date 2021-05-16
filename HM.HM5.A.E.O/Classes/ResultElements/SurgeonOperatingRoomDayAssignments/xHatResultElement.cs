namespace HM.HM5.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xHatResultElement : IxHatResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatResultElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public bool Value { get; }
    }
}
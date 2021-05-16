namespace HM.HM5.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomDayAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xParameterElement : IxParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xParameterElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            FhirBoolean value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}
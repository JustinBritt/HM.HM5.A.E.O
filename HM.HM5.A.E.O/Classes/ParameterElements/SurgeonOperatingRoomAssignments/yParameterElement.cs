﻿namespace HM.HM5.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;

    internal sealed class yParameterElement : IyParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yParameterElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            INullableValue<bool> value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public INullableValue<bool> Value { get; }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class lIndexElement : IlIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public INullableValue<int> Value { get; }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class tIndexElement : ItIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <inheritdoc/>
        public int Key { get; }

        /// <inheritdoc/>
        public FhirDateTime Value { get; }
    }
}
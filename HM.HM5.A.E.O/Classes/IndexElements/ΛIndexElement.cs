﻿namespace HM.HM5.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class ΛIndexElement : IΛIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΛIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the scenario.
        /// </summary>
        public INullableValue<int> Value { get; }
    }
}
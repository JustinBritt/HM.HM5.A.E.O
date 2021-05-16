﻿namespace HM.HM5.A.E.O.Classes.Parameters.MaximumNumberRecoveryWardBeds
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;

    internal sealed class Ω : IΩ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ω(
            PositiveInt value)
        {
            this.Value = value;
        }

        public PositiveInt Value { get; }
    }
}
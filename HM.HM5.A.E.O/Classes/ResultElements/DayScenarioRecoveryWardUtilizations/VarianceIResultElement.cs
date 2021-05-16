﻿namespace HM.HM5.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardUtilizations
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;

    internal sealed class VarianceIResultElement : IVarianceIResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceIResultElement(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            this.tIndexElement = tIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public ItIndexElement tIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public decimal Value { get; }
    }
}
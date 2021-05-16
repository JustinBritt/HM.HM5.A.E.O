﻿namespace HM.HM5.A.E.O.Classes.ResultElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ExpectedValueΦResultElement : IExpectedValueΦResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦResultElement(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public decimal Value { get; }
    }
}
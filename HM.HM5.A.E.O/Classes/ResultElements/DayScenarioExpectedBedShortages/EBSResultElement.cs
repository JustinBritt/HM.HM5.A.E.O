﻿namespace HM.HM5.A.E.O.Classes.ResultElements.DayScenarioExpectedBedShortages
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;

    internal sealed class EBSResultElement : IEBSResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElement(
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
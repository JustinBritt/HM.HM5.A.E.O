﻿namespace HM.HM5.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class srCrossJoinElement : IsrCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srCrossJoinElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }
    }
}
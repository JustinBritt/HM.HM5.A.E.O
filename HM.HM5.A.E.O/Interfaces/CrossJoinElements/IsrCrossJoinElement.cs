﻿namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IsrCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }
    }
}
﻿namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{   
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IrtCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}
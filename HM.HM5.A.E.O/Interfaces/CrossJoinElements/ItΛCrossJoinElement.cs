﻿namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface ItΛCrossJoinElement
    {
        ItIndexElement tIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }
    }
}
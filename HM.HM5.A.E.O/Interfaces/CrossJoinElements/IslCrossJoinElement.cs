﻿namespace HM.HM5.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IslCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }
    }
}
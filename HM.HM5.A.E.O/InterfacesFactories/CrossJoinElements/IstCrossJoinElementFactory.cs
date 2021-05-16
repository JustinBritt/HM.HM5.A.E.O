﻿namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IstCrossJoinElementFactory
    {
        IstCrossJoinElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);
    }
}
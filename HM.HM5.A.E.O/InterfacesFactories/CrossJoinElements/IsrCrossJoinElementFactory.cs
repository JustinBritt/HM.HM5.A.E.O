﻿namespace HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IsrCrossJoinElementFactory
    {
        IsrCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);
    }
}
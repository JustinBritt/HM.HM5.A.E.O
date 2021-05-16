﻿namespace HM.HM5.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IxHatFactory
    {
        IxHat Create(
            VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> value);
    }
}
﻿namespace HM.HM5.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IrIndexElementFactory
    {
        IrIndexElement Create(
            Location value);
    }
}
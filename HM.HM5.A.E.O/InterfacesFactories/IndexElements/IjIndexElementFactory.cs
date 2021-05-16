﻿namespace HM.HM5.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IjIndexElementFactory
    {
        IjIndexElement Create(
            Organization value);
    }
}
﻿namespace HM.HM5.A.E.O.InterfacesFactories.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    public interface ItFactory
    {
        It Create(
            RedBlackTree<FhirDateTime, ItIndexElement> value);
    }
}
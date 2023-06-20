﻿namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    
    public interface Is
    {
        RedBlackTree<Organization, IsIndexElement> Value { get; }

        IsIndexElement GetElementAt(
            Organization value);
    }
}
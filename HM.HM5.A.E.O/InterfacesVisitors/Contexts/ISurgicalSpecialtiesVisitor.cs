namespace HM.HM5.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface ISurgicalSpecialtiesVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : IImmutableSet<Organization>
    {
        RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> RedBlackTree { get; }

        List<IΔParameterElement> Value { get; }
    }
}
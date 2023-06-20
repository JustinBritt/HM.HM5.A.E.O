namespace HM.HM5.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using NGenerics.Patterns.Visitor;

    public interface ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        RedBlackTree<IΛIndexElement, InParameterElement> RedBlackTree { get; }
    }
}
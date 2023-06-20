﻿namespace HM.HM5.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;

    public interface ISurgeonDayScenarioLengthOfStayProbabilitiesFirstInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>> RedBlackTree { get; }
    }
}
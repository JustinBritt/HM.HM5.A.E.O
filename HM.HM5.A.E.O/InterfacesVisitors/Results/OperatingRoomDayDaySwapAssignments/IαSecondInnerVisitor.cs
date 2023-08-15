namespace HM.HM5.A.E.O.InterfacesVisitors.Results.OperatingRoomDayDaySwapAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;

    public interface IαSecondInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Id2IndexElement
        where TValue : IαResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<bool>> RedBlackTree { get; }
    }
}
namespace HM.HM5.A.E.O.InterfacesVisitors.Results.OperatingRoomDayDaySwapAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;

    public interface IαOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>
    {
        RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> RedBlackTree { get; }
    }
}
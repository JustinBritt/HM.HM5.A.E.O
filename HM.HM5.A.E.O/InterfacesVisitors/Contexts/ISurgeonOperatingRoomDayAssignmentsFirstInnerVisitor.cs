namespace HM.HM5.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;

    public interface ISurgeonOperatingRoomDayAssignmentsFirstInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Location
        where TValue : RedBlackTree<FhirDateTime, INullableValue<bool>>
    {
        RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>> RedBlackTree { get; }
    }
}
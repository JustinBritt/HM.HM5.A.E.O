namespace HM.HM5.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxHatOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>
    {
        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> RedBlackTree { get; }
    }
}
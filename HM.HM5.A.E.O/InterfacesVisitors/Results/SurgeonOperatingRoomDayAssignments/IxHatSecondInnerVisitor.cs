namespace HM.HM5.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxHatSecondInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : ItIndexElement
        where TValue : IxHatResultElement
    {
        RedBlackTree<FhirDateTime, INullableValue<bool>> RedBlackTree { get; }
    }
}
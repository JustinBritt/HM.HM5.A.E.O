namespace HM.HM5.A.E.O.Interfaces.Results.OperatingRoomDayDaySwapAssignments
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iα
    {
        RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> Value { get; }

        int GetElementAtAsint(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);

        RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
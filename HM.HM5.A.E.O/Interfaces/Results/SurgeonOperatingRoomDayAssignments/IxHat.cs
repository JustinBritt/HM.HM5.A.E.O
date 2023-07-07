namespace HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IxHat
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        ImmutableList<IxHatResultElement> GetElementsAsImmutableList();

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
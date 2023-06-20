namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Id2
    {
        RedBlackTree<INullableValue<int>, Id2IndexElement> Value { get; }

        Id2IndexElement GetElementAt(
            INullableValue<int> value);
    }
}
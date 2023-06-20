namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Id1
    {
        RedBlackTree<INullableValue<int>, Id1IndexElement> Value { get; }

        Id1IndexElement GetElementAt(
            INullableValue<int> value);
    }
}
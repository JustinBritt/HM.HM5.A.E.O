namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Il
    {
        RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        IlIndexElement GetElementAt(
            int value);

        IlIndexElement GetElementAt(
            INullableValue<int> value);
    }
}
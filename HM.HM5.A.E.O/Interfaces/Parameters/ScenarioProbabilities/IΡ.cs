namespace HM.HM5.A.E.O.Interfaces.Parameters.ScenarioProbabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡ
    {
        RedBlackTree<IΛIndexElement, IΡParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);
    }
}
namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    public interface IL
    {
        RedBlackTree<IsIndexElement, ILParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}
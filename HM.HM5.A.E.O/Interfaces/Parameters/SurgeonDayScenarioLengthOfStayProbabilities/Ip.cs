namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;

    public interface Ip
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}
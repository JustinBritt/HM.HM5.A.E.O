namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;

    public interface InFactory
    {
        In Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> value);
    }
}
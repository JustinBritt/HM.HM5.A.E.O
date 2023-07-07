namespace HM.HM5.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    public interface Iz
    {
        VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Is s,
            It t);
    }
}
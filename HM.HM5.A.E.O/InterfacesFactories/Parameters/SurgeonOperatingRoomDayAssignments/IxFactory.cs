namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>> value);
    }
}
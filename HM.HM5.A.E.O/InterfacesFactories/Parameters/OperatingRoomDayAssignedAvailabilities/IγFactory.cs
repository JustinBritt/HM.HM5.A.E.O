namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;

    public interface IγFactory
    {
        Iγ Create(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> value);
    }
}
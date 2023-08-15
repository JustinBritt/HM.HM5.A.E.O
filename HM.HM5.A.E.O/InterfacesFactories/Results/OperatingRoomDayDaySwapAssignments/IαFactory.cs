namespace HM.HM5.A.E.O.InterfacesFactories.Results.OperatingRoomDayDaySwapAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.OperatingRoomDayDaySwapAssignments;

    public interface IαFactory
    {
        Iα Create(
            RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> value);
    }
}
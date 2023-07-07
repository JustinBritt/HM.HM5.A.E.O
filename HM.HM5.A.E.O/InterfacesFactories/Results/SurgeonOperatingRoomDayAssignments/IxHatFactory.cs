namespace HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    
    public interface IxHatFactory
    {
        IxHat Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> value);
    }
}
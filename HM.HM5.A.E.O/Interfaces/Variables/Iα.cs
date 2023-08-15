namespace HM.HM5.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OperatingRoomDayDaySwapAssignments;

    public interface Iα
    {
        VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> Value { get; }

        bool GetElementAt(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);

        Interfaces.Results.OperatingRoomDayDaySwapAssignments.Iα GetElementsAt(
            IαResultElementFactory αResultElementFactory,
            IαFactory αFactory,
            Id1 d1,
            Id2 d2,
            Ir r);
    }
}
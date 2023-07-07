namespace HM.HM5.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    public interface IxHat
    {
        VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayAssignments.IxHat GetElementsAt(
            IxHatResultElementFactory xHatResultElementFactory,
            IxHatFactory xHatFactory,
            Ir r,
            Is s,
            It t);
    }
}
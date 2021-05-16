namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints9ConstraintElementFactory
    {
        IConstraints9ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ix x,
            IxHat xHat);
    }
}
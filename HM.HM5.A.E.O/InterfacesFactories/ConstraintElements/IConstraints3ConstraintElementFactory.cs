namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iy y,
            IxHat xHat);
    }
}
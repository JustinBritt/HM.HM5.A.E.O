namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints2ConstraintElementFactory
    {
        IConstraints2ConstraintElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Iγ γ,
            IxHat xHat);
    }
}
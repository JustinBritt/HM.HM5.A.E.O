namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints8ConstraintElementFactory
    {
        IConstraints8ConstraintElement Create(
            Id2IndexElement d2IndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Id1 d1,
            It t,
            Ix x,
            IxHat xHat,
            Iα α);
    }
}
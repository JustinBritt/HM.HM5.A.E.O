namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints6ConstraintElementFactory
    {
        IConstraints6ConstraintElement Create(
            Id2IndexElement d2IndexElement,
            IrIndexElement rIndexElement,
            Id1 d1,
            Iα α);
    }
}
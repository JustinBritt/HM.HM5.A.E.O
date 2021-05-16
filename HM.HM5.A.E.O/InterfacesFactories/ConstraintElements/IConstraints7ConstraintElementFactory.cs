namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints7ConstraintElementFactory
    {
        IConstraints7ConstraintElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            Iα α);
    }
}
namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints5ConstraintElementFactory
    {
        IConstraints5ConstraintElement Create(
            Id1IndexElement d1IndexElement,
            IrIndexElement rIndexElement,
            Id2 d2,
            Iα α);
    }
}
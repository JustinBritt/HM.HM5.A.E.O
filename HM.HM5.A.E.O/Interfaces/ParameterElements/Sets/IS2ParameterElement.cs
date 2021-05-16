namespace HM.HM5.A.E.O.Interfaces.ParameterElements.Sets
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IS2ParameterElement
    {
        IrIndexElement rIndexElement { get; }

        Id1IndexElement d1IndexElement { get; }

        Id2IndexElement d2IndexElement { get; }
    }
}
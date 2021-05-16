namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    public interface IS2ParameterElementFactory
    {
        IS2ParameterElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);
    }
}
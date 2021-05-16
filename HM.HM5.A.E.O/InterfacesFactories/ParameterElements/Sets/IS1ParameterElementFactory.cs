namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    public interface IS1ParameterElementFactory
    {
        IS1ParameterElement Create(
            IrIndexElement rIndexElement);
    }
}
namespace HM.HM5.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IαFactory
    {
        Iα Create(
            VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> value);
    }
}
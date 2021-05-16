namespace HM.HM5.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Iα
    {
        VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> Value { get; }
    }
}
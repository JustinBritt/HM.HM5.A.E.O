namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IObjectiveFunctionFactory CreateObjectiveFunctionFactory();
    }
}
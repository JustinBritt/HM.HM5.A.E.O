namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        IIHatFactory CreateIHatFactory();

        IxHatFactory CreatexHatFactory();

        IzFactory CreatezFactory();

        IαFactory CreateαFactory();
    }
}
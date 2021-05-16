namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Indices;

    public interface IIndicesAbstractFactory
    {
        Id1Factory Created1Factory();

        Id2Factory Created2Factory();

        IjFactory CreatejFactory();

        IlFactory CreatelFactory();

        IrFactory CreaterFactory();

        IsFactory CreatesFactory();

        ItFactory CreatetFactory();

        IΛFactory CreateΛFactory();
    }
}
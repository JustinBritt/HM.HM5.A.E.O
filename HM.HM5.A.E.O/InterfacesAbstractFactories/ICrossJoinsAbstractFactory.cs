namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    public interface ICrossJoinsAbstractFactory
    {
        Ird1Factory Createrd1Factory();

        Ird1d2Factory Createrd1d2Factory();

        Ird2Factory Createrd2Factory();

        IrtFactory CreatertFactory();

        IslFactory CreateslFactory();

        IslΛFactory CreateslΛFactory();

        IsrFactory CreatesrFactory();

        Isrd2Factory Createsrd2Factory();

        Isrd2tFactory Createsrd2tFactory();

        IsrtFactory CreatesrtFactory();

        IstFactory CreatestFactory();

        IsΛFactory CreatesΛFactory();

        ItΛFactory CreatetΛFactory();
    }
}
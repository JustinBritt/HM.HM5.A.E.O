namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Constraints;

    public interface IConstraintsAbstractFactory
    {
        IConstraints1Factory CreateConstraints1Factory();

        IConstraints2Factory CreateConstraints2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5Factory CreateConstraints5Factory();

        IConstraints6Factory CreateConstraints6Factory();

        IConstraints7Factory CreateConstraints7Factory();

        IConstraints8Factory CreateConstraints8Factory();

        IConstraints9Factory CreateConstraints9Factory();
    }
}
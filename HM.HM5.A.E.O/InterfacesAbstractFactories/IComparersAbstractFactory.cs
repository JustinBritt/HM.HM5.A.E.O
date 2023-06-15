namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}
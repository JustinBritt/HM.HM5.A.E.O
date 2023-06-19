namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory();

        ILocationComparerFactory CreateLocationComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}
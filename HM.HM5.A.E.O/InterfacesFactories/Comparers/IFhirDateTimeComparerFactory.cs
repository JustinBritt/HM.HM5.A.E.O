namespace HM.HM5.A.E.O.InterfacesFactories.Comparers
{
    using HM.HM5.A.E.O.Interfaces.Comparers;

    public interface IFhirDateTimeComparerFactory
    {
        IFhirDateTimeComparer Create();
    }
}
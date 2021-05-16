namespace HM.HM5.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage
{
    using HM.HM5.A.E.O.Interfaces.Results.TotalExpectedBedShortage;

    public interface ITEBSFactory
    {
        ITEBS Create(
            decimal value);
    }
}
namespace HM.HM5.A.E.O.InterfacesFactories.Results.BestBound
{
    using HM.HM5.A.E.O.Interfaces.Results.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}
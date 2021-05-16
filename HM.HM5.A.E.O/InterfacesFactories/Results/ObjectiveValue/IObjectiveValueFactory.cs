namespace HM.HM5.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using HM.HM5.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}
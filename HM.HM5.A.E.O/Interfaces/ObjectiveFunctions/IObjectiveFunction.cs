namespace HM.HM5.A.E.O.Interfaces.ObjectiveFunctions
{
    using OPTANO.Modeling.Optimization;

    public interface IObjectiveFunction
    {
        Objective Value { get; }
    }
}
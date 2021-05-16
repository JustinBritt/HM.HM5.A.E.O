namespace HM.HM5.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes
{
    using HM.HM5.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}
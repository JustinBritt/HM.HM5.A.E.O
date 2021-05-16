namespace HM.HM5.A.E.O.Interfaces.Results.NumberOfExploredNodes
{
    public interface INumberOfExploredNodes
    {
        long Value { get; }

        long GetValueForOutputContext();
    }
}
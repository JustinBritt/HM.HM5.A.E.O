namespace HM.HM5.A.E.O.Interfaces.Results.OverallWallTime
{
    using System;

    public interface IOverallWallTime
    {
        TimeSpan Value { get; }

        TimeSpan GetValueForOutputContext();
    }
}
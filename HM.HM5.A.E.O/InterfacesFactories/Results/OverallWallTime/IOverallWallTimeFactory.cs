namespace HM.HM5.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using HM.HM5.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
           TimeSpan value);
    }
}
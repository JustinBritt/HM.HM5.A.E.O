﻿namespace HM.HM5.A.E.O.Classes.Results.NumberOfExploredNodes
{
    using log4net;

    using HM.HM5.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodes : INumberOfExploredNodes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodes(
            long value)
        {
            this.Value = value;
        }

        public long Value { get; }

        public long GetValueForOutputContext()
        {
            return this.Value;
        }
    }
}
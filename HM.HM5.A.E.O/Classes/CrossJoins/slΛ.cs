﻿namespace HM.HM5.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;

    internal sealed class slΛ : IslΛ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public slΛ(
            ImmutableList<IslΛCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IslΛCrossJoinElement> Value { get; }
    }
}
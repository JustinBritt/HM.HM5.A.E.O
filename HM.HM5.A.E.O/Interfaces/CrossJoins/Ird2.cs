﻿namespace HM.HM5.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;

    public interface Ird2
    {
        ImmutableList<Ird2CrossJoinElement> Value { get; }
    }
}
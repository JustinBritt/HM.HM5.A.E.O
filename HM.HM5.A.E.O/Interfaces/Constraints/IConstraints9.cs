﻿namespace HM.HM5.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints9
    {
        ImmutableList<IConstraints9ConstraintElement> Value { get; }
    }
}
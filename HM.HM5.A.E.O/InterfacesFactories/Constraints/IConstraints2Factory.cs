﻿namespace HM.HM5.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    public interface IConstraints2Factory
    {
        IConstraints2 Create(
            ImmutableList<IConstraints2ConstraintElement> value);
    }
}
﻿namespace HM.HM5.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.Constraints;

    public interface IConstraints6Factory
    {
        IConstraints6 Create(
            ImmutableList<IConstraints6ConstraintElement> value);
    }
}
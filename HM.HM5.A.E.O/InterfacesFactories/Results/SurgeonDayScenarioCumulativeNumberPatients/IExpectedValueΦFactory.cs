﻿namespace HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IExpectedValueΦFactory
    {
        IExpectedValueΦ Create(
            ImmutableList<IExpectedValueΦResultElement> value,
            Il l,
            Is s,
            IΛ Λ);
    }
}
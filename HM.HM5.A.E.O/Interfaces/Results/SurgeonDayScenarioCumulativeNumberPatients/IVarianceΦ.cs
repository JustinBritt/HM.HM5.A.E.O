﻿namespace HM.HM5.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IVarianceΦ
    {
        ImmutableList<IVarianceΦResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}
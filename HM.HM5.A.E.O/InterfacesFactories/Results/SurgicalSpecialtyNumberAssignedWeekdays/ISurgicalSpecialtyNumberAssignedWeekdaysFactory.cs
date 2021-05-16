﻿namespace HM.HM5.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysFactory
    {
        ISurgicalSpecialtyNumberAssignedWeekdays Create(
            ImmutableList<ISurgicalSpecialtyNumberAssignedWeekdaysResultElement> value);
    }
}
﻿namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays
{
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysCalculation
    {
        ISurgeonNumberAssignedWeekdays Calculate(
            ISurgeonNumberAssignedWeekdaysResultElementFactory surgeonNumberAssignedWeekdaysResultElementFactory,
            ISurgeonNumberAssignedWeekdaysFactory surgeonNumberAssignedWeekdaysFactory,
            ISurgeonNumberAssignedWeekdaysResultElementCalculation surgeonNumberAssignedWeekdaysResultElementCalculation,
            Is s,
            IxHat xHat);
    }
}
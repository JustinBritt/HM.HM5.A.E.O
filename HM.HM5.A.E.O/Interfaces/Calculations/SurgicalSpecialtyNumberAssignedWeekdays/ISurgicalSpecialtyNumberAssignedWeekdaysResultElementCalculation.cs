namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation
    {
        ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            IΔParameterElement ΔParameterElement,
            IxHat xHat);
    }
}
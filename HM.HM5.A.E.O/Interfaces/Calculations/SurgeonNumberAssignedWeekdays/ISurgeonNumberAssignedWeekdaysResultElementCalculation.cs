namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysResultElementCalculation
    {
        ISurgeonNumberAssignedWeekdaysResultElement Calculate(
            ISurgeonNumberAssignedWeekdaysResultElementFactory surgeonNumberAssignedWeekdaysResultElementFactory,
            IsIndexElement sIndexElement,
            IxHat xHat);
    }
}
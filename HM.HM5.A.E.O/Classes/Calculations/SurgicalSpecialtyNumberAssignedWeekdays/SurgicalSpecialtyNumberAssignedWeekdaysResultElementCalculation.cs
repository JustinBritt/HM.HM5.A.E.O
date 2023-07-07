namespace HM.HM5.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation : ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            IΔParameterElement ΔParameterElement,
            IxHat xHat)
        {
            return surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                ΔParameterElement.Value.SelectMany(a => xHat.GetElementsAsImmutableList().Where(i => i.sIndexElement == a && i.Value).Select(i => i.tIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek)).Distinct().Count());
        }
    }
}
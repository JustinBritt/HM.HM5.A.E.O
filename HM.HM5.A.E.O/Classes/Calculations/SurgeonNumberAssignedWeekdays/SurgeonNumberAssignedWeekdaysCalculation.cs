namespace HM.HM5.A.E.O.Classes.Calculations.SurgeonNumberAssignedWeekdays
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysCalculation : ISurgeonNumberAssignedWeekdaysCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysCalculation()
        {
        }

        public ISurgeonNumberAssignedWeekdays Calculate(
            ISurgeonNumberAssignedWeekdaysResultElementFactory surgeonNumberAssignedWeekdaysResultElementFactory,
            ISurgeonNumberAssignedWeekdaysFactory surgeonNumberAssignedWeekdaysFactory,
            ISurgeonNumberAssignedWeekdaysResultElementCalculation surgeonNumberAssignedWeekdaysResultElementCalculation,
            Is s,
            IxHat xHat)
        {
            return surgeonNumberAssignedWeekdaysFactory.Create(
                s.Value
                .Select(w => surgeonNumberAssignedWeekdaysResultElementCalculation.Calculate(
                    surgeonNumberAssignedWeekdaysResultElementFactory,
                    w,
                    xHat))
                .ToImmutableList());
        }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.Calculations.ScenarioTotalTimes
{
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementCalculation : IScenarioTotalTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementCalculation()
        {
        }

        public IScenarioTotalTimesResultElement Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            Isrt srt,
            IH H,
            IxHat xHat)
        {
            return scenarioTotalTimesResultElementFactory.Create(
                ΛIndexElement,
                srt.Value.Select(w =>
                xHat.GetElementAtAsint(
                    w.sIndexElement,
                    w.rIndexElement,
                    w.tIndexElement)
                *
                H.Value.Value.Value)
                .Sum());
        }
    }
}
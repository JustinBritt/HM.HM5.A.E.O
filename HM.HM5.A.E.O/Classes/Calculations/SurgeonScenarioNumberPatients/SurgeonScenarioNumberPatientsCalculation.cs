﻿namespace HM.HM5.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsCalculation : ISurgeonScenarioNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsCalculation()
        {
        }

        public ISurgeonScenarioNumberPatients Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            ISurgeonScenarioNumberPatientsFactory surgeonScenarioNumberPatientsFactory,
            ISurgeonScenarioNumberPatientsResultElementCalculation surgeonScenarioNumberPatientsResultElementCalculation,
            Irt rt,
            IsΛ sΛ,
            In n,
            IxHat xHat)
        {
            return surgeonScenarioNumberPatientsFactory.Create(
                sΛ.Value
                .Select(w => surgeonScenarioNumberPatientsResultElementCalculation.Calculate(
                    surgeonScenarioNumberPatientsResultElementFactory,
                    w.sIndexElement,
                    w.ΛIndexElement,
                    rt,
                    n,
                    xHat))
                .ToImmutableList());
        }
    }
}
﻿namespace HM.HM5.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients
{
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsResultElementCalculation
    {
        ISurgeonScenarioNumberPatientsResultElement Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Irt rt,
            In n,
            IxHat xHat);
    }
}
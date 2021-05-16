﻿namespace HM.HM5.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations
{
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;

    public interface IExpectedValueIResultElementCalculation
    {
        IExpectedValueIResultElement Calculate(
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IExpectedValueΦ expectedValueΦ,
            Iz z);
    }
}
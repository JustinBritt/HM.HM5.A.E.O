﻿namespace HM.HM5.A.E.O.Classes.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ExpectedValueΦCalculation : IExpectedValueΦCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦCalculation()
        {
        }

        public IExpectedValueΦ Calculate(
            IExpectedValueΦResultElementFactory expectedValueΦResultElementFactory,
            IExpectedValueΦFactory expectedValueΦFactory,
            IExpectedValueΦResultElementCalculation expectedValueΦResultElementCalculation,
            Il l,
            Is s,
            It t,
            IΛ Λ,
            IslΛ slΛ,
            IL L,
            Ip p,
            Iμ μ)
        {
            return expectedValueΦFactory.Create(
                slΛ.Value
                .Select(i => expectedValueΦResultElementCalculation.Calculate(
                    expectedValueΦResultElementFactory,
                    i.lIndexElement,
                    i.sIndexElement,
                    i.ΛIndexElement,
                    l,
                    t,
                    L,
                    p,
                    μ))
                .ToImmutableList(),
                l,
                s,
                Λ);
        }
    }
}
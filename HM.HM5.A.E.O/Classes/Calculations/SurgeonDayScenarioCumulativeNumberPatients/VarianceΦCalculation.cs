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

    internal sealed class VarianceΦCalculation : IVarianceΦCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceΦCalculation()
        {
        }

        public IVarianceΦ Calculate(
            IVarianceΦResultElementFactory varianceΦResultElementFactory,
            IVarianceΦFactory varianceΦFactory,
            IVarianceΦResultElementCalculation varianceΦResultElementCalculation,
            Il l,
            Is s,
            It t,
            IΛ Λ,
            IslΛ slΛ,
            IL L,
            Ip p,
            Iμ μ,
            Iσ σ)
        {
            return varianceΦFactory.Create(
                slΛ.Value
                .Select(i => varianceΦResultElementCalculation.Calculate(
                    varianceΦResultElementFactory,
                    i.lIndexElement,
                    i.sIndexElement,
                    i.ΛIndexElement,
                    l,
                    t,
                    L,
                    p,
                    μ,
                    σ))
                .ToImmutableList(),
                l,
                s,
                Λ);
        }
    }
}
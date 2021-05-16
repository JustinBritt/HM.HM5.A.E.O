namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHat
    {
        ImmutableList<IΦHatParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}
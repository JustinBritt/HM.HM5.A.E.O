namespace HM.HM5.A.E.O.Interfaces.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡ
    {
        ImmutableList<IΡParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);
    }
}
namespace HM.HM5.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IΔParameterElement
    {
        IjIndexElement jIndexElement { get; }

        ImmutableList<IsIndexElement> Value { get; }
    }
}
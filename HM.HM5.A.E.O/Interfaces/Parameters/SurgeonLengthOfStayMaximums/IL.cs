namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    public interface IL
    {
        ImmutableList<ILParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}
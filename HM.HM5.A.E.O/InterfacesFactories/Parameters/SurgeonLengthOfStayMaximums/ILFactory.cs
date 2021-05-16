namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;

    public interface ILFactory
    {
        IL Create(
            ImmutableList<ILParameterElement> value);
    }
}
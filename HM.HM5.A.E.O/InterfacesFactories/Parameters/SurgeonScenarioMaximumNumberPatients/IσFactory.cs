namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;

    public interface IσFactory
    {
        Iσ Create(
            ImmutableList<IσParameterElement> value);
    }
}
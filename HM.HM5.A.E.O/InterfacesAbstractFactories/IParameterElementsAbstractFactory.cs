namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    public interface IParameterElementsAbstractFactory
    {
        IhParameterElementFactory CreatehParameterElementFactory();

        ILParameterElementFactory CreateLParameterElementFactory();

        InParameterElementFactory CreatenParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IS1ParameterElementFactory CreateS1ParameterElementFactory();

        IS2ParameterElementFactory CreateS2ParameterElementFactory();

        IxParameterElementFactory CreatexParameterElementFactory();

        IyParameterElementFactory CreateyParameterElementFactory();

        IγParameterElementFactory CreateγParameterElementFactory();

        IΔParameterElementFactory CreateΔParameterElementFactory();

        IμParameterElementFactory CreateμParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IσParameterElementFactory CreateσParameterElementFactory();

        IΦHatParameterElementFactory CreateΦHatParameterElementFactory();
    }
}
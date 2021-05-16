namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;

    public interface IParametersAbstractFactory
    {
        IHFactory CreateHFactory();

        IhFactory CreatehFactory();

        ILFactory CreateLFactory();

        InFactory CreatenFactory();

        IpFactory CreatepFactory();

        IS1Factory CreateS1Factory();

        IS2Factory CreateS2Factory();

        IWFactory CreateWFactory();

        IxFactory CreatexFactory();

        IyFactory CreateyFactory();

        IγFactory CreateγFactory();

        IΔFactory CreateΔFactory();

        IμFactory CreateμFactory();

        IΡFactory CreateΡFactory();

        IσFactory CreateσFactory();

        IΦHatFactory CreateΦHatFactory();

        IΩFactory CreateΩFactory();
    }
}
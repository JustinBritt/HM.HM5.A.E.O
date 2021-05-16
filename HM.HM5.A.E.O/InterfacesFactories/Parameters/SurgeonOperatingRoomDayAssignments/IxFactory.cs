namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            ImmutableList<IxParameterElement> value);
    }
}
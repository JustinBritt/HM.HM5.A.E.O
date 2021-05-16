namespace HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    
    public interface IxHatFactory
    {
        IxHat Create(
            ImmutableList<IxHatResultElement> value);
    }
}
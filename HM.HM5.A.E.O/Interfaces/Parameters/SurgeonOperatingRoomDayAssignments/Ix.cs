namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;

    public interface Ix
    {
        ImmutableList<IxParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);
    }
}
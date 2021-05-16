﻿namespace HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;

    public interface Iy
    {
        ImmutableList<IyParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);
    }
}
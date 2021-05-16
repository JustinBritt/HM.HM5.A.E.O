﻿namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;

    public interface IγFactory
    {
        Iγ Create(
            ImmutableList<IγParameterElement> value);
    }
}
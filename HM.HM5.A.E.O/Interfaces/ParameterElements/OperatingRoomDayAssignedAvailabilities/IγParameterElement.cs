﻿namespace HM.HM5.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IγParameterElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}
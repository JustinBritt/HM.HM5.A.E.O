﻿namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Il
    {
        ImmutableList<IlIndexElement> Value { get; }

        IlIndexElement GetElementAt(
            int value);

        IlIndexElement GetElementAt(
            INullableValue<int> value);
    }
}
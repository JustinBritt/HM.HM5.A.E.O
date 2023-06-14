﻿namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Id1
    {
        ImmutableList<Id1IndexElement> Value { get; }

        Id1IndexElement GetElementAt(
            INullableValue<int> value);
    }
}
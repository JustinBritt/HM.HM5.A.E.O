﻿namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;
  
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface IΛ
    {
        ImmutableList<IΛIndexElement> Value { get; }

        IΛIndexElement GetElementAt(
            PositiveInt value);
    }
}
﻿namespace HM.HM5.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IΛIndexElement : IComparable<IΛIndexElement>
    {
        /// <summary>
        /// Gets the scenario.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}
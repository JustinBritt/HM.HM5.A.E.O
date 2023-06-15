﻿namespace HM.HM5.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IsIndexElement : IComparable<IsIndexElement>
    {
        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        Organization Value { get; }
    }
}
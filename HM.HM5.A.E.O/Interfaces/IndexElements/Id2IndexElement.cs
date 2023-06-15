namespace HM.HM5.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface Id2IndexElement : IComparable<Id2IndexElement>
    {
        /// <summary>
        /// Gets the weekday.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}
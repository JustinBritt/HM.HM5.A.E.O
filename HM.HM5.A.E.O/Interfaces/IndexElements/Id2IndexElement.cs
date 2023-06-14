namespace HM.HM5.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface Id2IndexElement
    {
        /// <summary>
        /// Gets the weekday.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}
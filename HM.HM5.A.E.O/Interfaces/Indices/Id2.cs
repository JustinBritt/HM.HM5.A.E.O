namespace HM.HM5.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface Id2
    {
        ImmutableList<Id2IndexElement> Value { get; }

        Id2IndexElement GetElementAt(
            INullableValue<int> value);
    }
}
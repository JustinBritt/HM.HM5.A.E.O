namespace HM.HM5.A.E.O.Interfaces.Parameters.Sets
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    public interface IS2
    {
        ImmutableList<IS2ParameterElement> Value { get; }

        bool IsThereElementAt(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);
    }
}
namespace HM.HM5.A.E.O.Interfaces.Parameters.Sets
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;

    public interface IS1
    {
        ImmutableList<IS1ParameterElement> Value { get; }

        bool IsThereElementAt(
            IrIndexElement rIndexElement);
    }
}
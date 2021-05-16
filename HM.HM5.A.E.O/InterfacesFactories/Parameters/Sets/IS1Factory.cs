namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;

    public interface IS1Factory
    {
        IS1 Create(
            ImmutableList<IS1ParameterElement> value);
    }
}
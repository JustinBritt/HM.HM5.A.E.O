namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets
{
    using System.Collections.Immutable;

    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;

    public interface IS2Factory
    {
        IS2 Create(
            ImmutableList<IS2ParameterElement> value);
    }
}
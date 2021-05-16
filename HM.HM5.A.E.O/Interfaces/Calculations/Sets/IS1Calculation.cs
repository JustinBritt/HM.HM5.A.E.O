namespace HM.HM5.A.E.O.Interfaces.Calculations.Sets
{
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    public interface IS1Calculation
    {
        IS1 Calculate(
            IS1ParameterElementFactory S1ParameterElementFactory,
            IS1Factory S1Factory,
            Ir r,
            Ix x,
            IΔ Δ);
    }
}
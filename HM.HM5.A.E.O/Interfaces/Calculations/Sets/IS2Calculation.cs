namespace HM.HM5.A.E.O.Interfaces.Calculations.Sets
{
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    public interface IS2Calculation
    {
        IS2 Calculate(
            IS2ParameterElementFactory S2ParameterElementFactory,
            IS2Factory S2Factory,
            Id1 d1,
            Id2 d2,
            Ir r,
            It t,
            Ird1d2 rd1d2,
            IW W,
            Ix x,
            IΔ Δ);
    }
}
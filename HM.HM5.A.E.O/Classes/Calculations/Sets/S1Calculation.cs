namespace HM.HM5.A.E.O.Classes.Calculations.Sets
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.Sets;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    internal sealed class S1Calculation : IS1Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1Calculation()
        {
        }

        public IS1 Calculate(
            IS1ParameterElementFactory S1ParameterElementFactory,
            IS1Factory S1Factory,
            Ir r,
            Ix x,
            IΔ Δ)
        {
            return S1Factory.Create(
                r.Value.Values
                .Select(
                    i => Tuple.Create(
                        i,
                        x.GetElementsAsImmutableList()
                        .Where(j => j.rIndexElement == i && j.Value.Value.Value)
                        .Select(j => j.sIndexElement)
                        .Select(j => Δ.GetSurgicalSpecialtyOfSurgeon(j).Value)
                        .Distinct()
                        .Count()))
                .Where(i => i.Item2 > 1)
                .Select(i => S1ParameterElementFactory.Create(i.Item1))
                .ToImmutableList());
        }
    }
}
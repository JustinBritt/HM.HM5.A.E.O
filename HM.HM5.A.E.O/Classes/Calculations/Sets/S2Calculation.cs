namespace HM.HM5.A.E.O.Classes.Calculations.Sets
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.Sets;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;

    internal sealed class S2Calculation : IS2Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2Calculation()
        {
        }

        public IS2 Calculate(
            IS2ParameterElementFactory S2ParameterElementFactory,
            IS2Factory S2Factory,
            Id1 d1,
            Id2 d2,
            Ir r,
            It t,
            Ird1d2 rd1d2,
            IW W,
            Ix x,
            IΔ Δ)
        {
            return S2Factory.Create(
                rd1d2.Value
                .Where(i => i.d1IndexElement.Value.Value.Value != i.d2IndexElement.Value.Value.Value)
                // rd1d2t1
                .SelectMany(b => t.GetNthElementsAt(
                    b.d1IndexElement.Value.Value.Value,
                    t.GetT() - W.Value.Value.Value + b.d1IndexElement.Value.Value.Value,
                    W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.rIndexElement, a.d1IndexElement, a.d2IndexElement, b))
                // rd1d2t1t2
                .SelectMany(b => t.GetNthElementsAt(
                    b.Item3.Value.Value.Value,
                    t.GetT() - W.Value.Value.Value + b.Item3.Value.Value.Value,
                    W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.Item1, a.Item2, a.Item3, a.Item4, b))
                .Select(
                i => Tuple.Create(
                    i.Item1,
                    i.Item2,
                    i.Item3,
                    i.Item4,
                    i.Item5,
                    // x(j, r, t)
                    x.GetElementsAsImmutableList()
                    .Where(j => j.Value.Value.Value)
                    .Select(j => Tuple.Create(
                                Δ.GetSurgicalSpecialtyOfSurgeon(j.sIndexElement),
                                j.rIndexElement,
                                j.tIndexElement))
                    .Where(j => j.Item2 == i.Item1)
                    .Select(j => j.Item1)
                    .Distinct()
                    .Count()))
                .Where(i => i.Item6 == 1)
                .Select(i => S2ParameterElementFactory
                            .Create(
                                i.Item1,
                                i.Item2,
                                i.Item3))
                .ToImmutableList());
        }
    }
}
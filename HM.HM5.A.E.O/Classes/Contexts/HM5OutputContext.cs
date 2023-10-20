namespace HM.HM5.A.E.O.Classes.Contexts
{
    using System;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Solver;

    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.Models;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    
    internal sealed class HM5OutputContext : IHM5OutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5OutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM5Model HM5Model,
            Solution solution)
        {
            if (solution.ModelStatus == ModelStatus.Feasible)
            {
                // BestBound
                this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                    (decimal)solution.BestBound)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // Gap
                this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                    (decimal)solution.Gap)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // IsFeasible
                this.IsFeasible = true;

                // NumberOfExploredNodes
                this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                    solution.NumberOfExploredNodes)
                    .GetValueForOutputContext();

                // ObjectiveValue
                this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                    (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // OverallWallTime
                this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                    solution.OverallWallTime)
                    .GetValueForOutputContext();

                // IHat(t, Λ)
                this.DayScenarioRecoveryWardCensuses = HM5Model.IHat.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateIHatResultElementFactory(),
                    resultsAbstractFactory.CreateIHatFactory(),
                    HM5Model.t,
                    HM5Model.Λ)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // xHat(s, r, t)
                IxHat xHat = HM5Model.xHat.GetElementsAt(
                    resultElementsAbstractFactory.CreatexHatResultElementFactory(),
                    resultsAbstractFactory.CreatexHatFactory(),
                    HM5Model.r,
                    HM5Model.s,
                    HM5Model.t);

                this.SurgeonOperatingRoomDayAssignments = xHat
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgeonNumberAssignedOperatingRooms
                this.SurgeonNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsFactory(),
                    calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                    HM5Model.s,
                    xHat)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgeonNumberAssignedWeekdays
                this.SurgeonNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysFactory(),
                    calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                    HM5Model.s,
                    xHat)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgeonScenarioNumberPatients
                ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients = calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonScenarioNumberPatientsFactory(),
                    calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory().Create(),
                    HM5Model.rt,
                    HM5Model.sΛ,
                    HM5Model.n,
                    xHat);

                this.SurgeonScenarioNumberPatients = surgeonScenarioNumberPatients.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM5Model.s,
                    HM5Model.Λ);

                // ScenarioNumberPatients(Λ)
                this.ScenarioNumberPatients = calculationsAbstractFactory.CreateScenarioNumberPatientsCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioNumberPatientsResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioNumberPatientsFactory(),
                    calculationsAbstractFactory.CreateScenarioNumberPatientsResultElementCalculationFactory().Create(),
                    HM5Model.Λ,
                    surgeonScenarioNumberPatients)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgicalSpecialtyNumberAssignedOperatingRooms
                this.SurgicalSpecialtyNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory(),
                    calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                    HM5Model.Δ,
                    xHat)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgicalSpecialtyNumberAssignedWeekdays
                this.SurgicalSpecialtyNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory(),
                    resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory(),
                    calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                    HM5Model.Δ,
                    xHat)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // z(s, t) 
                Interfaces.Results.SurgeonDayAssignments.Iz z = HM5Model.z.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreatezResultElementFactory(),
                    resultsAbstractFactory.CreatezFactory(),
                    HM5Model.s,
                    HM5Model.t);

                this.SurgeonDayAssignments = z
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ExpectedValueΦ(s, l, Λ)
                Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients.IExpectedValueΦ expectedValueΦ = calculationsAbstractFactory.CreateExpectedValueΦCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateExpectedValueΦResultElementFactory(),
                    resultsAbstractFactory.CreateExpectedValueΦFactory(),
                    calculationsAbstractFactory.CreateExpectedValueΦResultElementCalculationFactory().Create(),
                    HM5Model.l,
                    HM5Model.s,
                    HM5Model.t,
                    HM5Model.Λ,
                    HM5Model.slΛ,
                    HM5Model.L,
                    HM5Model.p,
                    HM5Model.μ);

                // VarianceΦ(s, l, Λ)
                Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients.IVarianceΦ varianceΦ = calculationsAbstractFactory.CreateVarianceΦCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateVarianceΦResultElementFactory(),
                    resultsAbstractFactory.CreateVarianceΦFactory(),
                    calculationsAbstractFactory.CreateVarianceΦResultElementCalculationFactory().Create(),
                    HM5Model.l,
                    HM5Model.s,
                    HM5Model.t,
                    HM5Model.Λ,
                    HM5Model.slΛ,
                    HM5Model.L,
                    HM5Model.p,
                    HM5Model.μ,
                    HM5Model.σ);

                // ExpectedValueI(t, Λ)
                Interfaces.Results.DayScenarioRecoveryWardUtilizations.IExpectedValueI expectedValueI = calculationsAbstractFactory.CreateExpectedValueICalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateExpectedValueIResultElementFactory(),
                    resultsAbstractFactory.CreateExpectedValueIFactory(),
                    calculationsAbstractFactory.CreateExpectedValueIResultElementCalculationFactory().Create(),
                    HM5Model.l,
                    HM5Model.t,
                    HM5Model.st,
                    HM5Model.tΛ,
                    expectedValueΦ,
                    z);

                this.DayScenarioRecoveryWardUtilizationExpectedValues = expectedValueI
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM5Model.t,
                    HM5Model.Λ);

                // VarianceI(t, Λ)
                Interfaces.Results.DayScenarioRecoveryWardUtilizations.IVarianceI varianceI = calculationsAbstractFactory.CreateVarianceICalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateVarianceIResultElementFactory(),
                    resultsAbstractFactory.CreateVarianceIFactory(),
                    calculationsAbstractFactory.CreateVarianceIResultElementCalculationFactory().Create(),
                    HM5Model.l,
                    HM5Model.t,
                    HM5Model.st,
                    HM5Model.tΛ,
                    varianceΦ,
                    z);

                this.DayScenarioRecoveryWardUtilizationVariances = varianceI
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM5Model.t,
                    HM5Model.Λ);

                // EBS(t, Λ)
                Interfaces.Results.DayScenarioExpectedBedShortages.IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                    resultsAbstractFactory.CreateEBSFactory(),
                    calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                    HM5Model.tΛ,
                    HM5Model.Ω,
                    expectedValueI,
                    varianceI);

                this.DayScenarioExpectedBedShortages = EBS
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM5Model.t,
                    HM5Model.Λ);

                // TEBS(Λ)
                Interfaces.Results.ScenarioTotalExpectedBedShortages.ITEBS TEBS_Λ = calculationsAbstractFactory.CreateTEBSΛCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateTEBSΛResultElementFactory(),
                    resultsAbstractFactory.CreateTEBSΛFactory(),
                    calculationsAbstractFactory.CreateTEBSΛResultElementCalculationFactory().Create(),
                    HM5Model.t,
                    HM5Model.Λ,
                    EBS);

                this.ScenarioTotalExpectedBedShortages = TEBS_Λ
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // TEBS
                this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                    .Calculate(
                    resultsAbstractFactory.CreateTEBSFactory(),
                    HM5Model.Λ,
                    HM5Model.Ρ,
                    TEBS_Λ)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioTotalTimes(Λ)
                IScenarioTotalTimes scenarioTotalTimes = calculationsAbstractFactory.CreateScenarioTotalTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioTotalTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioTotalTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioTotalTimesResultElementCalculationFactory().Create(),
                    HM5Model.Λ,
                    HM5Model.srt,
                    HM5Model.H,
                    xHat);

                this.ScenarioTotalTimes = scenarioTotalTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUtilizedTimes(Λ)
                IScenarioUtilizedTimes scenarioUtilizedTimes = calculationsAbstractFactory.CreateScenarioUtilizedTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUtilizedTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUtilizedTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioUtilizedTimesResultElementCalculationFactory().Create(),
                    HM5Model.Λ,
                    HM5Model.srt,
                    HM5Model.h,
                    HM5Model.n,
                    xHat);

                this.ScenarioUtilizedTimes = scenarioUtilizedTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUnutilizedTimes(Λ)
                IScenarioUnutilizedTimes scenarioUnutilizedTimes = calculationsAbstractFactory.CreateScenarioUnutilizedTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUnutilizedTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUnutilizedTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioUnutilizedTimesResultElementCalculationFactory().Create(),
                    HM5Model.Λ,
                    scenarioTotalTimes,
                    scenarioUtilizedTimes);

                this.ScenarioUnutilizedTimes = scenarioUnutilizedTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUnderutilizations(Λ)
                this.ScenarioUnderutilizations = calculationsAbstractFactory.CreateScenarioUnderutilizationsCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUnderutilizationsResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUnderutilizationsFactory(),
                    calculationsAbstractFactory.CreateScenarioUnderutilizationsResultElementCalculationFactory().Create(),
                    HM5Model.Λ,
                    scenarioTotalTimes,
                    scenarioUnutilizedTimes)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // α(r, d1, d2)
                this.OperatingRoomDayDaySwapAssignments = HM5Model.α.GetElementsAt(
                    resultElementsAbstractFactory.CreateαResultElementFactory(),
                    resultsAbstractFactory.CreateαFactory(),
                    HM5Model.d1,
                    HM5Model.d2,
                    HM5Model.r)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());
            }
            else
            {
                this.IsFeasible = false;
            }
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        public INullableValue<decimal> Gap { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        public bool IsFeasible { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> ScenarioNumberPatients { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnderutilizations { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnutilizedTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUtilizedTimes { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedWeekdays { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalExpectedBedShortages { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }

        public RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> OperatingRoomDayDaySwapAssignments { get; }
    }
}
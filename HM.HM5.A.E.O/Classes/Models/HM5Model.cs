﻿namespace HM.HM5.A.E.O.Classes.Models
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.Interfaces.Contexts;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Models;
    using HM.HM5.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM5.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.Sets;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class HM5Model : IHM5Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM5Model(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM5InputContext HM5InputContext)
        {
            this.Context = HM5InputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // d1
            this.d1 = indicesAbstractFactory.Created1Factory().Create(
                this.Context.Weekdays
                .Select(x => indexElementsAbstractFactory.Created1IndexElementFactory().Create(x))
                .ToImmutableList());

            // d2
            this.d2 = indicesAbstractFactory.Created2Factory().Create(
               this.Context.Weekdays
               .Select(x => indexElementsAbstractFactory.Created2IndexElementFactory().Create(x))
               .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            this.t = indicesAbstractFactory.CreatetFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatetIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // rd1
            this.rd1 = crossJoinsAbstractFactory.Createrd1Factory().Create(
                this.r.Value
                .SelectMany(b => this.d1.Value, (a, b) => crossJoinElementsAbstractFactory.Createrd1CrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rd1d2
            this.rd1d2 = crossJoinsAbstractFactory.Createrd1d2Factory().Create(
                this.r.Value
                .SelectMany(b => this.d1.Value, (a, b) => crossJoinElementsAbstractFactory.Createrd1CrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d2.Value, (a, b) => crossJoinElementsAbstractFactory.Createrd1d2CrossJoinElementFactory().Create(a.rIndexElement, a.d1IndexElement, b))
                .ToImmutableList());

            // rd2
            this.rd2 = crossJoinsAbstractFactory.Createrd2Factory().Create(
                this.r.Value
                .SelectMany(b => this.d2.Value, (a, b) => crossJoinElementsAbstractFactory.Createrd2CrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rt
            this.rt = crossJoinsAbstractFactory.CreatertFactory().Create(
                this.r.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatertCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // slΛ
            this.slΛ = crossJoinsAbstractFactory.CreateslΛFactory().Create(
               this.s.Value
               .SelectMany(b => this.l.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslCrossJoinElementFactory().Create(a, b))
               .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslΛCrossJoinElementFactory().Create(a.sIndexElement, a.lIndexElement, b))
               .ToImmutableList());

            // srd2
            this.srd2 = crossJoinsAbstractFactory.Createsrd2Factory().Create(
               this.s.Value
               .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
               .SelectMany(b => this.d2.Value, (a, b) => crossJoinElementsAbstractFactory.Createsrd2CrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
               .ToImmutableList());

            // srd2t
            this.srd2t = crossJoinsAbstractFactory.Createsrd2tFactory().Create(
               this.s.Value
               .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
               .SelectMany(b => this.d2.Value, (a, b) => crossJoinElementsAbstractFactory.Createsrd2CrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
               .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.Createsrd2tCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, a.d2IndexElement, b))
               .ToImmutableList());

            // srt
            this.srt = crossJoinsAbstractFactory.CreatesrtFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrtCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // st
            this.st = crossJoinsAbstractFactory.CreatestFactory().Create(
                this.s.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatestCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // tΛ
            this.tΛ = crossJoinsAbstractFactory.CreatetΛFactory().Create(
                this.t.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatetΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // H
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.TimeBlockLength);

            // h(s, Λ)
            ISurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor = new HM.HM5.A.E.O.Visitors.Contexts.SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, Duration>>(
                parameterElementsAbstractFactory.CreatehParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioWeightedAverageSurgicalDurations.AcceptVisitor(
                surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor);

            this.h = parametersAbstractFactory.CreatehFactory().Create(
                surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor.RedBlackTree);

            // L(s)
            ISurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>> surgeonLengthOfStayMaximumsVisitor = new HM.HM5.A.E.O.Visitors.Contexts.SurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateLParameterElementFactory(),
                this.s);

            this.Context.SurgeonLengthOfStayMaximums.AcceptVisitor(
                surgeonLengthOfStayMaximumsVisitor);

            this.L = parametersAbstractFactory.CreateLFactory().Create(
                surgeonLengthOfStayMaximumsVisitor.RedBlackTree);

            // n(s, Λ)
            ISurgeonScenarioMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatientsOuterVisitor = new HM.HM5.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                parameterElementsAbstractFactory.CreatenParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatients.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientsOuterVisitor);

            this.n = parametersAbstractFactory.CreatenFactory().Create(
                surgeonScenarioMaximumNumberPatientsOuterVisitor.RedBlackTree);

            // p(s, l, Λ)
            this.p = parametersAbstractFactory.CreatepFactory().Create(
                this.Context.SurgeonDayScenarioLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreatepParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.Λ.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // Δ(j)
            // Must be populated before S1
            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => parameterElementsAbstractFactory.CreateΔParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // x(s, r, t)
            // Must be populated before S1
            this.x = parametersAbstractFactory.CreatexFactory().Create(
                this.Context.SurgeonOperatingRoomDayAssignments
                .Select(x => parameterElementsAbstractFactory.CreatexParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.r.GetElementAt(x.Item2),
                    this.t.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // S1
            this.S1 = calculationsAbstractFactory.CreateS1CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.CreateS1ParameterElementFactory(),
                parametersAbstractFactory.CreateS1Factory(),
                this.r,
                this.x,
                this.Δ);

            // W
            // Must be populated before S2
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                this.Context.NumberDaysPerWeek);

            // S2
            this.S2 = calculationsAbstractFactory.CreateS2CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.CreateS2ParameterElementFactory(),
                parametersAbstractFactory.CreateS2Factory(),
                this.d1,
                this.d2,
                this.r,
                this.t,
                this.rd1d2,
                this.W,
                this.x,
                this.Δ);

            // y(s, r)
            this.y = parametersAbstractFactory.CreateyFactory().Create(
                this.Context.SurgeonOperatingRoomAssignments
                .Select(x => parameterElementsAbstractFactory.CreateyParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.r.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // γ(r, t)
            this.γ = parametersAbstractFactory.CreateγFactory().Create(
                this.Context.OperatingRoomDayAssignedAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateγParameterElementFactory().Create(
                    this.r.GetElementAt(x.Item1),
                    this.t.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // μ(s, Λ)
            ISurgeonScenarioMaximumNumberPatientMeansOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeansOuterVisitor = new HM.HM5.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientMeansOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreateμParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatientMeans.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientMeansOuterVisitor);

            this.μ = parametersAbstractFactory.CreateμFactory().Create(
                surgeonScenarioMaximumNumberPatientMeansOuterVisitor.RedBlackTree);

            // Ρ(Λ)
            IScenarioProbabilitiesVisitor<INullableValue<int>, INullableValue<decimal>> scenarioProbabilitiesVisitor = new HM.HM5.A.E.O.Visitors.Contexts.ScenarioProbabilitiesVisitor<INullableValue<int>, INullableValue<decimal>>(
                parameterElementsAbstractFactory.CreateΡParameterElementFactory(),
                this.Λ);

            this.Context.ScenarioProbabilities.AcceptVisitor(
                scenarioProbabilitiesVisitor);

            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                scenarioProbabilitiesVisitor.RedBlackTree);

            // σ(s, Λ)
            ISurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor = new HM.HM5.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreateσParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatientStandardDeviations.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor);

            this.σ = parametersAbstractFactory.CreateσFactory().Create(
                surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor.RedBlackTree);

            // ΦHat(s, l, Λ)
            this.ΦHat = parametersAbstractFactory.CreateΦHatFactory().Create(
                this.Context.SurgeonDayScenarioCumulativeNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreateΦHatParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.Λ.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // Ω
            this.Ω = parametersAbstractFactory.CreateΩFactory().Create(
                this.Context.MaximumNumberRecoveryWardBeds);

            // Variables

            // IHat(t, Λ)
            this.IHat = variablesAbstractFactory.CreateIHatFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model,
                    indexSet1: this.t.Value, 
                    indexSet2: this.Λ.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous)); 

            // xHat(s, r, t)
            this.xHat = variablesAbstractFactory.CreatexHatFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.r.Value,
                    indexSet3: this.t.Value, 
                    lowerBoundGenerator: (a, b, c) => 0, 
                    upperBoundGenerator: (a, b, c) => 1, 
                    variableTypeGenerator: (a, b, c) => VariableType.Binary)); 

            // z(s, t)
            this.z = variablesAbstractFactory.CreatezFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.t.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => 1, 
                    variableTypeGenerator: (a, b) => VariableType.Binary));

            // α(r, d1, d2)
            this.α = variablesAbstractFactory.CreateαFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.r.Value, 
                    indexSet2: this.d1.Value, 
                    indexSet3: this.d2.Value, 
                    lowerBoundGenerator: (a, b, c) => 0, 
                    upperBoundGenerator: (a, b, c) => 1, 
                    variableTypeGenerator: (a, b, c) => VariableType.Binary)); 

            // Constraints

            // Constraints 1
            this.Model.AddConstraints(
                this.st.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1ConstraintElementFactory().Create(
                        x.sIndexElement,
                        x.tIndexElement,
                        this.r,
                        this.xHat,
                        this.z)
                    .Value));

            // Constraints 2
            this.Model.AddConstraints(
                this.rt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.tIndexElement,
                        this.s,
                        this.γ,
                        this.xHat)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.srt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        x.tIndexElement,
                        this.y,
                        this.xHat)
                    .Value));

            // Constraints 4
            this.Model.AddConstraints(
                this.tΛ.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        x.tIndexElement,
                        x.ΛIndexElement,
                        this.l,
                        this.t,
                        this.st,
                        this.ΦHat,
                        this.IHat,
                        this.z)
                    .Value));

            // Constraints 5
            this.Model.AddConstraints(
                this.rd1.Value
                .Where(x => this.S1.IsThereElementAt(x.rIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5ConstraintElementFactory().Create(
                        x.d1IndexElement,
                        x.rIndexElement,
                        this.d2,
                        this.α)
                    .Value));

            // Constraints 6
            this.Model.AddConstraints(
                this.rd2.Value
                .Where(x => this.S1.IsThereElementAt(x.rIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints6ConstraintElementFactory().Create(
                        x.d2IndexElement,
                        x.rIndexElement,
                        this.d1,
                        this.α)
                    .Value));

            // Constraints 7
            this.Model.AddConstraints(
                this.rd1d2.Value
                .Where(x => this.S1.IsThereElementAt(x.rIndexElement))
                .Where(x => this.S2.IsThereElementAt(
                    x.rIndexElement,
                    x.d1IndexElement,
                    x.d2IndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints7ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.d1IndexElement,
                        x.d2IndexElement,
                        this.α)
                    .Value));

            // Constraints 8
            this.Model.AddConstraints(
                this.srd2.Value
                .Where(x => this.S1.IsThereElementAt(x.rIndexElement))
                .SelectMany(b =>
                this.t.GetNthElementsAt(
                    0,
                    this.W.Value.Value.Value * ((this.t.GetT() / this.W.Value.Value.Value) - 1),
                    this.W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.rIndexElement, a.d2IndexElement, b))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints8ConstraintElementFactory().Create(
                        x.Item3,
                        x.Item2,
                        x.Item1,
                        x.Item4,
                        this.d1,
                        this.t,
                        this.x,
                        this.xHat,
                        this.α)
                    .Value));

            // Constraints 9
            this.Model.AddConstraints(
                this.srt.Value
                .Where(x => !this.S1.IsThereElementAt(x.rIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints9ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        x.tIndexElement,
                        this.x,
                        this.xHat)
                    .Value));

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.t,
                    this.Λ,
                    this.Ρ,
                    this.IHat)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IHM5InputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Id1 d1 { get; }

        public Id2 d2 { get; }

        public Ij j { get; }

        public Il l { get; }

        public Ir r { get; }

        public Is s { get; }

        public It t { get; }

        public IΛ Λ { get; }

        public Ird1 rd1 { get; }

        public Ird1d2 rd1d2 { get; }

        public Ird2 rd2 { get; }

        public Irt rt { get; }

        public IslΛ slΛ { get; }

        public Isrd2 srd2 { get; }

        public Isrd2t srd2t { get; }

        public Isrt srt { get; }

        public Ist st { get; }

        public IsΛ sΛ { get; }

        public ItΛ tΛ { get; }

        public IH H { get; }

        public Ih h { get; }

        public IL L { get; }

        public In n { get; }

        public Ip p { get; }

        public IS1 S1 { get; }

        public IS2 S2 { get; }

        public IW W { get; }

        public Ix x { get; }

        public Iy y { get; }

        public Iγ γ { get; }

        public IΔ Δ { get; }

        public Iμ μ { get; }

        public IΡ Ρ { get; }

        public Iσ σ { get; }

        public IΦHat ΦHat { get; }

        public IΩ Ω { get; }

        public IIHat IHat { get; }

        public IxHat xHat { get; }

        public Iz z { get; }

        public Iα α { get; }
    }
}
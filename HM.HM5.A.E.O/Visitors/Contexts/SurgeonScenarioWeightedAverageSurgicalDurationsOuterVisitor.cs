﻿namespace HM.HM5.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<TKey, TValue> : ISurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, Duration>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor(
            IhParameterElementFactory hParameterElementFactory,
            Is s,
            IΛ Λ)
        {
            this.hParameterElementFactory = hParameterElementFactory;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IhParameterElement>>();
        }

        private IhParameterElementFactory hParameterElementFactory { get; }

        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IhParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, Duration> value = obj.Value;

            var innerVisitor = new SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<INullableValue<int>, Duration>(
                this.hParameterElementFactory,
                sIndexElement,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}
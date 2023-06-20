﻿namespace HM.HM5.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<TKey, TValue> : ISurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : Duration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor(
            IhParameterElementFactory hParameterElementFactory,
            IsIndexElement sIndexElement,
            IΛ Λ)
        {
            this.hParameterElementFactory = hParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IΛIndexElement, IhParameterElement>();
        }

        private IhParameterElementFactory hParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, IhParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.hParameterElementFactory.Create(
                    this.sIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}
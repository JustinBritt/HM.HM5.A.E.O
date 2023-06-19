﻿namespace HM.HM5.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonLengthOfStayMaximumsVisitor<TKey, TValue> : ISurgeonLengthOfStayMaximumsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonLengthOfStayMaximumsVisitor(
            ILParameterElementFactory LParameterElementFactory,
            Is s)
        {
            this.LParameterElementFactory = LParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, ILParameterElement>();
        }

        private ILParameterElementFactory LParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, ILParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            INullableValue<int> value = obj.Value;

            this.RedBlackTree.Add(
                sIndexElement,
                this.LParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}
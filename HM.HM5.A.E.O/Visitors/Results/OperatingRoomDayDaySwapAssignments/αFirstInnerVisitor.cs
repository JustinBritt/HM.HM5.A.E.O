namespace HM.HM5.A.E.O.Visitors.Results.OperatingRoomDayDaySwapAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesVisitors.Results.OperatingRoomDayDaySwapAssignments;

    internal sealed class αFirstInnerVisitor<TKey, TValue> : IαFirstInnerVisitor<TKey, TValue>
        where TKey : Id1IndexElement
        where TValue : RedBlackTree<Id2IndexElement, IαResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = new RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>(
                this.NullableValueintComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        private IOrganizationComparer OrganizationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            Id1IndexElement d1IndexElement = obj.Key;

            RedBlackTree<Id2IndexElement, IαResultElement> value = obj.Value;

            IαSecondInnerVisitor<Id2IndexElement, IαResultElement> innerVisitor = new αSecondInnerVisitor<Id2IndexElement, IαResultElement>(
                this.NullableValueFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                d1IndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}
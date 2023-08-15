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

    internal sealed class αOuterVisitor<TKey, TValue> : IαOuterVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αOuterVisitor(
            INullableValueFactory nullableValueFactory,
            ILocationComparer locationComparer,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = new RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = obj.Key;

            RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>> value = obj.Value;

            IαFirstInnerVisitor<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>> innerVisitor = new αFirstInnerVisitor<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>(
                this.NullableValueFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}
namespace HM.HM5.A.E.O.Visitors.Results.OperatingRoomDayDaySwapAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesVisitors.Results.OperatingRoomDayDaySwapAssignments;

    internal sealed class αSecondInnerVisitor<TKey, TValue> : IαSecondInnerVisitor<TKey, TValue>
        where TKey : Id2IndexElement
        where TValue : IαResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αSecondInnerVisitor(
            INullableValueFactory nullableValueFactory,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<bool>>(
                nullableValueintComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<INullableValue<int>, INullableValue<bool>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<bool>(
                    obj.Value.Value));
        }
    }
}
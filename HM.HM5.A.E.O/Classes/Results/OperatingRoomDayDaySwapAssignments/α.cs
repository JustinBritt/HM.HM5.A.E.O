namespace HM.HM5.A.E.O.Classes.Results.OperatingRoomDayDaySwapAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesVisitors.Results.OperatingRoomDayDaySwapAssignments;

    internal sealed class α : Iα
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public α(
            RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> Value { get; }

        public int GetElementAtAsint(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            return this.Value[rIndexElement][d1IndexElement][d2IndexElement].Value ? 1 : 0;
        }

        public RedBlackTree<Location, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IαOuterVisitor<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> αOuterVisitor = new HM.HM5.A.E.O.Visitors.Results.OperatingRoomDayDaySwapAssignments.αOuterVisitor<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>>(
                nullableValueFactory,
                new HM.HM5.A.E.O.Classes.Comparers.LocationComparer(),
                new HM.HM5.A.E.O.Classes.Comparers.NullableValueintComparer());

            this.Value.AcceptVisitor(
                αOuterVisitor);

            return αOuterVisitor.RedBlackTree;
        }
    }
}
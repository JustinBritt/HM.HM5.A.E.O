namespace HM.HM5.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomDayAssignmentsOuterVisitor<TKey, TValue> : ISurgeonOperatingRoomDayAssignmentsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayAssignmentsOuterVisitor(
            IxParameterElementFactory xParameterElementFactory,
            Ir r,
            Is s,
            It t)
        {
            this.xParameterElementFactory = xParameterElementFactory;

            this.r = r;

            this.s = s;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>>();
        }

        private IxParameterElementFactory xParameterElementFactory { get; }

        private Ir r { get; }

        private Is s { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> value = obj.Value;

            ISurgeonOperatingRoomDayAssignmentsFirstInnerVisitor<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> innerVisitor = new SurgeonOperatingRoomDayAssignmentsFirstInnerVisitor<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                this.xParameterElementFactory,
                sIndexElement,
                this.r,
                this.t);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}
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

    internal sealed class SurgeonOperatingRoomDayAssignmentsFirstInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomDayAssignmentsFirstInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : RedBlackTree<FhirDateTime, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayAssignmentsFirstInnerVisitor(
            IxParameterElementFactory xParameterElementFactory,
            IsIndexElement sIndexElement,
            Ir r,
            It t)
        {
            this.xParameterElementFactory = xParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.r = r;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>();
        }

        private IxParameterElementFactory xParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Ir r { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            RedBlackTree<FhirDateTime, INullableValue<bool>> value = obj.Value;

            ISurgeonOperatingRoomDayAssignmentsSecondInnerVisitor<FhirDateTime, INullableValue<bool>> innerVisitor = new SurgeonOperatingRoomDayAssignmentsSecondInnerVisitor<FhirDateTime, INullableValue<bool>>(
                this.xParameterElementFactory,
                rIndexElement,
                this.sIndexElement,
                this.t);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}
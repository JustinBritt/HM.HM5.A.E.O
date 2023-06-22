namespace HM.HM5.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomDayAssignmentsSecondInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomDayAssignmentsSecondInnerVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayAssignmentsSecondInnerVisitor(
            IxParameterElementFactory xParameterElementFactory,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            It t)
        {
            this.xParameterElementFactory = xParameterElementFactory;

            this.rIndexElement = rIndexElement;

            this.sIndexElement = sIndexElement;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<ItIndexElement, IxParameterElement>();
        }

        private IxParameterElementFactory xParameterElementFactory { get; }

        private IrIndexElement rIndexElement { get; }

        private IsIndexElement sIndexElement { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ItIndexElement, IxParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ItIndexElement tIndexElement = this.t.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                tIndexElement,
                this.xParameterElementFactory.Create(
                    this.sIndexElement,
                    this.rIndexElement,
                    tIndexElement,
                    obj.Value));
        }
    }
}
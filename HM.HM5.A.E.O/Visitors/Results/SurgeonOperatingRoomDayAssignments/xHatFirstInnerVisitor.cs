namespace HM.HM5.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class xHatFirstInnerVisitor<TKey, TValue> : IxHatFirstInnerVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : RedBlackTree<ItIndexElement, IxHatResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.RedBlackTree = new RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private IOrganizationComparer OrganizationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = obj.Key;

            RedBlackTree<ItIndexElement, IxHatResultElement> value = obj.Value;

            IxHatSecondInnerVisitor<ItIndexElement, IxHatResultElement> innerVisitor = new xHatSecondInnerVisitor<ItIndexElement, IxHatResultElement>(
                this.NullableValueFactory,
                this.FhirDateTimeComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}
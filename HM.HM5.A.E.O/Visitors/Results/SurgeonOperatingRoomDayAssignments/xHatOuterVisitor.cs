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

    internal sealed class xHatOuterVisitor<TKey, TValue> : IxHatOuterVisitor<TKey, TValue>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.LocationComparer = locationComparer;

            this.OrganizationComparer = organizationComparer;

            this.RedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private ILocationComparer LocationComparer { get; }

        private IOrganizationComparer OrganizationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>> value = obj.Value;

            IxHatFirstInnerVisitor<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>> innerVisitor = new xHatFirstInnerVisitor<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>(
                this.NullableValueFactory,
                this.FhirDateTimeComparer,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}
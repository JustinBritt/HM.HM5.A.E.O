namespace HM.HM5.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;
    
    internal sealed class xHat : IxHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHat(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[sIndexElement][rIndexElement][tIndexElement].Value ? 1 : 0;
        }

        public ImmutableList<IxHatResultElement> GetElementsAsImmutableList()
        {
            return this.Value.SelectMany(w => w.Value).SelectMany(w => w.Value).Select(w => w.Value).ToImmutableList();
        }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IxHatOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> xHatOuterVisitor = new HM.HM5.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments.xHatOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>>(
                nullableValueFactory,
                new HM.HM5.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new HM.HM5.A.E.O.Classes.Comparers.LocationComparer(),
                new HM.HM5.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                xHatOuterVisitor);

            return xHatOuterVisitor.RedBlackTree;
        }
    }
}
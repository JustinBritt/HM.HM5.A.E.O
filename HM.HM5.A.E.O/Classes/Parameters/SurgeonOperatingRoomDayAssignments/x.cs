namespace HM.HM5.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>> value)
        {
            this.Value = value;
        }

        private RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[sIndexElement][rIndexElement][tIndexElement].Value.Value.Value ? 1 : 0;
        }

        public ImmutableList<IxParameterElement> GetElementsAsImmutableList()
        {
            return this.Value.SelectMany(w => w.Value).SelectMany(w => w.Value).Select(w => w.Value).ToImmutableList();
        }
    }
}
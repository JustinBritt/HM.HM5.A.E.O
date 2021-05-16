namespace HM.HM5.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            ImmutableList<IxParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IxParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(y => y.sIndexElement == sIndexElement && y.rIndexElement == rIndexElement && y.tIndexElement == tIndexElement)
                .Select(y => y.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}
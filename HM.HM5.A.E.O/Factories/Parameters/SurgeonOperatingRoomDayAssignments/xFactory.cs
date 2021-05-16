namespace HM.HM5.A.E.O.Factories.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayAssignments;

    internal sealed class xFactory : IxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFactory()
        {
        }

        public Ix Create(
            ImmutableList<IxParameterElement> value)
        {
            Ix parameter = null;

            try
            {
                parameter = new x(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}
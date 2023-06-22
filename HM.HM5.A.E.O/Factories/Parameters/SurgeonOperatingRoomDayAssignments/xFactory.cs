namespace HM.HM5.A.E.O.Factories.Parameters.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
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
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxParameterElement>>> value)
        {
            Ix parameter = null;

            try
            {
                parameter = new x(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
namespace HM.HM5.A.E.O.Factories.Results.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class xHatFactory : IxHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatFactory()
        {
        }

        public IxHat Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> value)
        {
            IxHat result = null;

            try
            {
                result = new xHat(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}
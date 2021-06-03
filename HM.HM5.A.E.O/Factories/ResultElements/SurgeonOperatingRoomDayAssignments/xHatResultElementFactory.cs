namespace HM.HM5.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xHatResultElementFactory : IxHatResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHatResultElementFactory()
        {
        }

        public IxHatResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            IxHatResultElement resultElement = null;

            try
            {
                resultElement = new xHatResultElement(
                    sIndexElement,
                    rIndexElement,
                    tIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}
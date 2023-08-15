namespace HM.HM5.A.E.O.Factories.ResultElements.OperatingRoomDayDaySwapAssignments
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments;

    internal sealed class αResultElementFactory : IαResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αResultElementFactory()
        {
        }

        public IαResultElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement,
            bool value)
        {
            IαResultElement instance = null;

            try
            {
                instance = new αResultElement(
                    rIndexElement,
                    d1IndexElement,
                    d2IndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}
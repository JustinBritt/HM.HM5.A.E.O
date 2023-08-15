namespace HM.HM5.A.E.O.Factories.Results.OperatingRoomDayDaySwapAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Classes.Results.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.Results.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OperatingRoomDayDaySwapAssignments;

    internal sealed class αFactory : IαFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αFactory()
        {
        }

        public Iα Create(
            RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> value)
        {
            Iα instance = null;

            try
            {
                instance = new α(
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
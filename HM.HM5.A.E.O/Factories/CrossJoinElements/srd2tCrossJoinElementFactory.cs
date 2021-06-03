namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srd2tCrossJoinElementFactory : Isrd2tCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srd2tCrossJoinElementFactory()
        {
        }

        public Isrd2tCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement,
            ItIndexElement tIndexElement)
        {
            Isrd2tCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srd2tCrossJoinElement(
                    sIndexElement,
                    rIndexElement,
                    d2IndexElement,
                    tIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}
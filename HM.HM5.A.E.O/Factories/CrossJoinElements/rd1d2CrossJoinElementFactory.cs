namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class rd1d2CrossJoinElementFactory : Ird1d2CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1d2CrossJoinElementFactory()
        {
        }

        public Ird1d2CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            Ird1d2CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rd1d2CrossJoinElement(
                    rIndexElement,
                    d1IndexElement,
                    d2IndexElement);
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
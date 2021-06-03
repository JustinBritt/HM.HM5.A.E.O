namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class rd1CrossJoinElementFactory : Ird1CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1CrossJoinElementFactory()
        {
        }

        public Ird1CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement)
        {
            Ird1CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rd1CrossJoinElement(
                    rIndexElement,
                    d1IndexElement);
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
namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class rd2CrossJoinElementFactory : Ird2CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd2CrossJoinElementFactory()
        {
        }

        public Ird2CrossJoinElement Create(
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement)
        {
            Ird2CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rd2CrossJoinElement(
                    rIndexElement,
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
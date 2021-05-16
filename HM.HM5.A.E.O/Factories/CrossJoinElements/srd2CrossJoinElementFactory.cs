namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;
 
    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srd2CrossJoinElementFactory : Isrd2CrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srd2CrossJoinElementFactory()
        {
        }

        public Isrd2CrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            Id2IndexElement d2IndexElement)
        {
            Isrd2CrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srd2CrossJoinElement(
                    sIndexElement,
                    rIndexElement,
                    d2IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}
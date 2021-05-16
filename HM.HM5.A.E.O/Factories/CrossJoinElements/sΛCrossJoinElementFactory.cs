namespace HM.HM5.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class sΛCrossJoinElementFactory : IsΛCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sΛCrossJoinElementFactory()
        {
        }

        public IsΛCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            IsΛCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new sΛCrossJoinElement(
                    sIndexElement,
                    ΛIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}
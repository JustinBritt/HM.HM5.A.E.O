namespace HM.HM5.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Classes.IndexElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class d1IndexElementFactory : Id1IndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1IndexElementFactory()
        {
        }

        public Id1IndexElement Create(
            INullableValue<int> value)
        {
            Id1IndexElement indexElement = null;

            try
            {
                indexElement = new d1IndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}
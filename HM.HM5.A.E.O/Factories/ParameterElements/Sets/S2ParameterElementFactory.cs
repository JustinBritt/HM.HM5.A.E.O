namespace HM.HM5.A.E.O.Factories.ParameterElements.Sets
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;

    internal sealed class S2ParameterElementFactory : IS2ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2ParameterElementFactory()
        {
        }

        public IS2ParameterElement Create(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            IS2ParameterElement parameterElement = null;

            try
            {
                parameterElement = new S2ParameterElement(
                    rIndexElement,
                    d1IndexElement,
                    d2IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}
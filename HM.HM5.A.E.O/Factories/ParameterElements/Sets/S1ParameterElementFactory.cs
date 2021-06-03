namespace HM.HM5.A.E.O.Factories.ParameterElements.Sets
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Classes.ParameterElements.Sets;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;

    internal sealed class S1ParameterElementFactory : IS1ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1ParameterElementFactory()
        {
        }

        public IS1ParameterElement Create(
            IrIndexElement rIndexElement)
        {
            IS1ParameterElement parameterElement = null;

            try
            {
                parameterElement = new S1ParameterElement(
                    rIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}
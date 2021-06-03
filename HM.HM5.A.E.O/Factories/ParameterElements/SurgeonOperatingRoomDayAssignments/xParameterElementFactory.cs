namespace HM.HM5.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xParameterElementFactory : IxParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xParameterElementFactory()
        {
        }

        public IxParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            FhirBoolean value)
        {
            IxParameterElement parameterElement = null;

            try
            {
                parameterElement = new xParameterElement(
                    sIndexElement,
                    rIndexElement,
                    tIndexElement,
                    value);
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
﻿namespace HM.HM5.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Classes.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    internal sealed class nParameterElementFactory : InParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElementFactory()
        {
        }

        public InParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<int> value)
        {
            InParameterElement parameterElement = null;

            try
            {
                parameterElement = new nParameterElement(
                    sIndexElement,
                    ΛIndexElement,
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
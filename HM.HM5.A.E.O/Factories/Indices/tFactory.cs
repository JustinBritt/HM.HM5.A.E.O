﻿namespace HM.HM5.A.E.O.Factories.Indices
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Classes.Indices;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class tFactory : ItFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tFactory()
        {
        }

        public It Create(
            RedBlackTree<FhirDateTime, ItIndexElement> value)
        {
            It index = null;

            try
            {
                index = new t(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Classes.Variables;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.Variables;

    internal sealed class IHatFactory : IIHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatFactory()
        {
        }

        public IIHat Create(
            VariableCollection<ItIndexElement, IΛIndexElement> value)
        {
            IIHat variable = null;

            try
            {
                variable = new IHat(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}
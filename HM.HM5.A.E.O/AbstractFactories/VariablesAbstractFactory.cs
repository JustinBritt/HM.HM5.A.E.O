namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Variables;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Variables;

    internal sealed class VariablesAbstractFactory : IVariablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariablesAbstractFactory()
        {
        }

        public IIHatFactory CreateIHatFactory()
        {
            IIHatFactory factory = null;

            try
            {
                factory = new IHatFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxHatFactory CreatexHatFactory()
        {
            IxHatFactory factory = null;

            try
            {
                factory = new xHatFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IzFactory CreatezFactory()
        {
            IzFactory factory = null;

            try
            {
                factory = new zFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IαFactory CreateαFactory()
        {
            IαFactory factory = null;

            try
            {
                factory = new αFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}
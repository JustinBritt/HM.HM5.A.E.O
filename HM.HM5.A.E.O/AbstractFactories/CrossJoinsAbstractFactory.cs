namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.CrossJoins;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public Ird1Factory Createrd1Factory()
        {
            Ird1Factory factory = null;

            try
            {
                factory = new rd1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ird1d2Factory Createrd1d2Factory()
        {
            Ird1d2Factory factory = null;

            try
            {
                factory = new rd1d2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Ird2Factory Createrd2Factory()
        {
            Ird2Factory factory = null;

            try
            {
                factory = new rd2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrtFactory CreatertFactory()
        {
            IrtFactory factory = null;

            try
            {
                factory = new rtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslFactory CreateslFactory()
        {
            IslFactory factory = null;

            try
            {
                factory = new slFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslΛFactory CreateslΛFactory()
        {
            IslΛFactory factory = null;

            try
            {
                factory = new slΛFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrFactory CreatesrFactory()
        {
            IsrFactory factory = null;

            try
            {
                factory = new srFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Isrd2Factory Createsrd2Factory()
        {
            Isrd2Factory factory = null;

            try
            {
                factory = new srd2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Isrd2tFactory Createsrd2tFactory()
        {
            Isrd2tFactory factory = null;

            try
            {
                factory = new srd2tFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrtFactory CreatesrtFactory()
        {
            IsrtFactory factory = null;

            try
            {
                factory = new srtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IstFactory CreatestFactory()
        {
            IstFactory factory = null;

            try
            {
                factory = new stFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsΛFactory CreatesΛFactory()
        {
            IsΛFactory factory = null;

            try
            {
                factory = new sΛFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItΛFactory CreatetΛFactory()
        {
            ItΛFactory factory = null;

            try
            {
                factory = new tΛFactory();
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
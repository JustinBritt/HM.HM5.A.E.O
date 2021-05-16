namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Constraints;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Constraints;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IConstraints1Factory CreateConstraints1Factory()
        {
            IConstraints1Factory factory = null;

            try
            {
                factory = new Constraints1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints2Factory CreateConstraints2Factory()
        {
            IConstraints2Factory factory = null;

            try
            {
                factory = new Constraints2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints3Factory CreateConstraints3Factory()
        {
            IConstraints3Factory factory = null;

            try
            {
                factory = new Constraints3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints5Factory CreateConstraints5Factory()
        {
            IConstraints5Factory factory = null;

            try
            {
                factory = new Constraints5Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints6Factory CreateConstraints6Factory()
        {
            IConstraints6Factory factory = null;

            try
            {
                factory = new Constraints6Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints7Factory CreateConstraints7Factory()
        {
            IConstraints7Factory factory = null;

            try
            {
                factory = new Constraints7Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints8Factory CreateConstraints8Factory()
        {
            IConstraints8Factory factory = null;

            try
            {
                factory = new Constraints8Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints9Factory CreateConstraints9Factory()
        {
            IConstraints9Factory factory = null;

            try
            {
                factory = new Constraints9Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
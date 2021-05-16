namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.CrossJoinElements;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public Ird1CrossJoinElementFactory Createrd1CrossJoinElementFactory()
        {
            Ird1CrossJoinElementFactory factory = null;

            try
            {
                factory = new rd1CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ird1d2CrossJoinElementFactory Createrd1d2CrossJoinElementFactory()
        {
            Ird1d2CrossJoinElementFactory factory = null;

            try
            {
                factory = new rd1d2CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Ird2CrossJoinElementFactory Createrd2CrossJoinElementFactory()
        {
            Ird2CrossJoinElementFactory factory = null;

            try
            {
                factory = new rd2CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrtCrossJoinElementFactory CreatertCrossJoinElementFactory()
        {
            IrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new rtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IslCrossJoinElementFactory CreateslCrossJoinElementFactory()
        {
            IslCrossJoinElementFactory factory = null;

            try
            {
                factory = new slCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory()
        {
            IslΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new slΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory()
        {
            IsrCrossJoinElementFactory factory = null;

            try
            {
                factory = new srCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isrd2CrossJoinElementFactory Createsrd2CrossJoinElementFactory()
        {
            Isrd2CrossJoinElementFactory factory = null;

            try
            {
                factory = new srd2CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isrd2tCrossJoinElementFactory Createsrd2tCrossJoinElementFactory()
        {
            Isrd2tCrossJoinElementFactory factory = null;

            try
            {
                factory = new srd2tCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory()
        {
            IsrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new srtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IstCrossJoinElementFactory CreatestCrossJoinElementFactory()
        {
            IstCrossJoinElementFactory factory = null;

            try
            {
                factory = new stCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory()
        {
            IsΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new sΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory()
        {
            ItΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new tΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
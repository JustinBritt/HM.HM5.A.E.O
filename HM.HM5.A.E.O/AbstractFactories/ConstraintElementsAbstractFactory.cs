﻿namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;
 
    using log4net;

    using HM.HM5.A.E.O.Factories.ConstraintElements;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory()
        {
            IConstraints1ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints1ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory()
        {
            IConstraints2ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints2ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory()
        {
            IConstraints3ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints3ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory()
        {
            IConstraints4ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints4ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5ConstraintElementFactory CreateConstraints5ConstraintElementFactory()
        {
            IConstraints5ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints6ConstraintElementFactory CreateConstraints6ConstraintElementFactory()
        {
            IConstraints6ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints6ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints7ConstraintElementFactory CreateConstraints7ConstraintElementFactory()
        {
            IConstraints7ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints7ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints8ConstraintElementFactory CreateConstraints8ConstraintElementFactory()
        {
            IConstraints8ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints8ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory()
        {
            IConstraints9ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints9ConstraintElementFactory();
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
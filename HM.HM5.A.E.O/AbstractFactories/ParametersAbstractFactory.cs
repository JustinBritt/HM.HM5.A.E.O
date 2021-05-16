﻿namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM5.A.E.O.Factories.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.Factories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Factories.Parameters.ScenarioProbabilities;
    using HM.HM5.A.E.O.Factories.Parameters.Sets;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Factories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.Factories.Parameters.TimeBlockLength;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IHFactory CreateHFactory()
        {
            IHFactory factory = null;

            try
            {
                factory = new HFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IhFactory CreatehFactory()
        {
            IhFactory factory = null;

            try
            {
                factory = new hFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILFactory CreateLFactory()
        {
            ILFactory factory = null;

            try
            {
                factory = new LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public InFactory CreatenFactory()
        {
            InFactory factory = null;

            try
            {
                factory = new nFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IS1Factory CreateS1Factory()
        {
            IS1Factory factory = null;

            try
            {
                factory = new S1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IS2Factory CreateS2Factory()
        {
            IS2Factory factory = null;

            try
            {
                factory = new S2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWFactory CreateWFactory()
        {
            IWFactory factory = null;

            try
            {
                factory = new WFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IyFactory CreateyFactory()
        {
            IyFactory factory = null;

            try
            {
                factory = new yFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IγFactory CreateγFactory()
        {
            IγFactory factory = null;

            try
            {
                factory = new γFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΔFactory CreateΔFactory()
        {
            IΔFactory factory = null;

            try
            {
                factory = new ΔFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΡFactory CreateΡFactory()
        {
            IΡFactory factory = null;

            try
            {
                factory = new ΡFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IσFactory CreateσFactory()
        {
            IσFactory factory = null;

            try
            {
                factory = new σFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΦHatFactory CreateΦHatFactory()
        {
            IΦHatFactory factory = null;

            try
            {
                factory = new ΦHatFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΩFactory CreateΩFactory()
        {
            IΩFactory factory = null;

            try
            {
                factory = new ΩFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
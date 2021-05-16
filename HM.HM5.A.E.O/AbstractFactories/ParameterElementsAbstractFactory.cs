namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.Factories.ParameterElements.ScenarioProbabilities;
    using HM.HM5.A.E.O.Factories.ParameterElements.Sets;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.Sets;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IhParameterElementFactory CreatehParameterElementFactory()
        {
            IhParameterElementFactory factory = null;

            try
            {
                factory = new hParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILParameterElementFactory CreateLParameterElementFactory()
        {
            ILParameterElementFactory factory = null;

            try
            {
                factory = new LParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public InParameterElementFactory CreatenParameterElementFactory()
        {
            InParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IS1ParameterElementFactory CreateS1ParameterElementFactory()
        {
            IS1ParameterElementFactory factory = null;

            try
            {
                factory = new S1ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IS2ParameterElementFactory CreateS2ParameterElementFactory()
        {
            IS2ParameterElementFactory factory = null;

            try
            {
                factory = new S2ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IxParameterElementFactory CreatexParameterElementFactory()
        {
            IxParameterElementFactory factory = null;

            try
            {
                factory = new xParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IyParameterElementFactory CreateyParameterElementFactory()
        {
            IyParameterElementFactory factory = null;

            try
            {
                factory = new yParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IγParameterElementFactory CreateγParameterElementFactory()
        {
            IγParameterElementFactory factory = null;

            try
            {
                factory = new γParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΔParameterElementFactory CreateΔParameterElementFactory()
        {
            IΔParameterElementFactory factory = null;

            try
            {
                factory = new ΔParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμParameterElementFactory CreateμParameterElementFactory()
        {
            IμParameterElementFactory factory = null;

            try
            {
                factory = new μParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IσParameterElementFactory CreateσParameterElementFactory()
        {
            IσParameterElementFactory factory = null;

            try
            {
                factory = new σParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΦHatParameterElementFactory CreateΦHatParameterElementFactory()
        {
            IΦHatParameterElementFactory factory = null;

            try
            {
                factory = new ΦHatParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}
﻿namespace HM.HM5.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM5.A.E.O.Factories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.Factories.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioTotalTimes;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.Factories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonDayAssignments;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesAbstractFactories;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public IEBSResultElementFactory CreateEBSResultElementFactory()
        {
            IEBSResultElementFactory factory = null;

            try
            {
                factory = new EBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueIResultElementFactory CreateExpectedValueIResultElementFactory()
        {
            IExpectedValueIResultElementFactory factory = null;

            try
            {
                factory = new ExpectedValueIResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueΦResultElementFactory CreateExpectedValueΦResultElementFactory()
        {
            IExpectedValueΦResultElementFactory factory = null;

            try
            {
                factory = new ExpectedValueΦResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIHatResultElementFactory CreateIHatResultElementFactory()
        {
            IIHatResultElementFactory factory = null;

            try
            {
                factory = new IHatResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory()
        {
            IScenarioNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory()
        {
            IScenarioTotalTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory()
        {
            IScenarioUnderutilizationsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory()
        {
            IScenarioUnutilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory()
        {
            IScenarioUtilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedWeekdaysResultElementFactory CreateSurgeonNumberAssignedWeekdaysResultElementFactory()
        {
            ISurgeonNumberAssignedWeekdaysResultElementFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedWeekdaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsResultElementFactory CreateSurgeonScenarioNumberPatientsResultElementFactory()
        {
            ISurgeonScenarioNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITEBSResultElementFactory CreateTEBSΛResultElementFactory()
        {
            ITEBSResultElementFactory factory = null;

            try
            {
                factory = new TEBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceIResultElementFactory CreateVarianceIResultElementFactory()
        {
            IVarianceIResultElementFactory factory = null;

            try
            {
                factory = new VarianceIResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceΦResultElementFactory CreateVarianceΦResultElementFactory()
        {
            IVarianceΦResultElementFactory factory = null;

            try
            {
                factory = new VarianceΦResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxHatResultElementFactory CreatexHatResultElementFactory()
        {
            IxHatResultElementFactory factory = null;

            try
            {
                factory = new xHatResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IzResultElementFactory CreatezResultElementFactory()
        {
            IzResultElementFactory factory = null;

            try
            {
                factory = new zResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IαResultElementFactory CreateαResultElementFactory()
        {
            IαResultElementFactory factory = null;

            try
            {
                factory = new αResultElementFactory();
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
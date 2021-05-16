namespace HM.HM5.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients
{
    using System.Linq;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementCalculation : ISurgeonScenarioNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementCalculation()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElement Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Irt rt,
            In n,
            IxHat xHat)
        {
            return surgeonScenarioNumberPatientsResultElementFactory.Create(
                sIndexElement,
                ΛIndexElement,
                rt.Value
                .Select(a =>
                xHat.GetElementAtAsint(
                    sIndexElement,
                    a.rIndexElement,
                    a.tIndexElement)
                *
                n.GetElementAtAsint(
                    sIndexElement,
                    ΛIndexElement))
                .Sum());
        }
    }
}
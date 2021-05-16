namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHatParameterElementFactory
    {
        IΦHatParameterElement Create(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            FhirDecimal value);
    }
}
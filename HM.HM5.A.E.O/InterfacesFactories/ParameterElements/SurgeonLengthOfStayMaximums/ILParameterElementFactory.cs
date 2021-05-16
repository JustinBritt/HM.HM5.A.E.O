namespace HM.HM5.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    public interface ILParameterElementFactory
    {
        ILParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value);
    }
}
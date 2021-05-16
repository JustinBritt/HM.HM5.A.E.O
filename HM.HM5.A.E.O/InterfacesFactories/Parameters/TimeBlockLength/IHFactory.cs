namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.TimeBlockLength
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.Parameters.TimeBlockLength;

    public interface IHFactory
    {
        IH Create(
            Duration value);
    }
}
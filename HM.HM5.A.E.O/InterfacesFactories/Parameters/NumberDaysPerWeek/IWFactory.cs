namespace HM.HM5.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek
{
    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;

    public interface IWFactory
    {
        IW Create(
            INullableValue<int> value);
    }
}
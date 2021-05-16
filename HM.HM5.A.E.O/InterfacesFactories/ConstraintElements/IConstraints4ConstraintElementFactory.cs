namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IΦHat ΦVHat,
            IIHat IHat,
            Iz z);
    }
}
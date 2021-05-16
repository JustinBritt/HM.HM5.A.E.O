namespace HM.HM5.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM5.A.E.O.Interfaces.ConstraintElements;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.Variables;

    public interface IConstraints1ConstraintElementFactory
    {
        IConstraints1ConstraintElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            IxHat xHat,
            Iz z);
    }
}
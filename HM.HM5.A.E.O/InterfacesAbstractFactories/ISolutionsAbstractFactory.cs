namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Solutions;

    public interface ISolutionsAbstractFactory
    {
        IHM5SolutionFactory CreateHM5SolutionFactory();
    }
}
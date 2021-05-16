namespace HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory
    {
        ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Create(
            IjIndexElement jIndexElement,
            int value);
    }
}
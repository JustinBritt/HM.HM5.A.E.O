namespace HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface ISurgeonNumberAssignedWeekdaysResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}
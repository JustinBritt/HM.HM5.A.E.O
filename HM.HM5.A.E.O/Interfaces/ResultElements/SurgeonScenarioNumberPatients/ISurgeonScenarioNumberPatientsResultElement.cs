﻿namespace HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients
{
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    public interface ISurgeonScenarioNumberPatientsResultElement
    {
        IsIndexElement sIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        int Value { get; }
    }
}
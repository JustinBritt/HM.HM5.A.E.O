﻿namespace HM.HM5.A.E.O.InterfacesFactories.Results.Gap
{
    using HM.HM5.A.E.O.Interfaces.Results.Gap;

    public interface IGapFactory
    {
        IGap Create(
            decimal value);
    }
}
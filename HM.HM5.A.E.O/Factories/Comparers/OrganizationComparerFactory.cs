﻿namespace HM.HM5.A.E.O.Factories.Comparers
{
    using HM.HM5.A.E.O.Classes.Comparers;
    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.InterfacesFactories.Comparers;

    internal sealed class OrganizationComparerFactory : IOrganizationComparerFactory
    {
        public OrganizationComparerFactory()
        {
        }

        public IOrganizationComparer Create()
        {
            IOrganizationComparer instance = null;

            try
            {
                instance = new OrganizationComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}
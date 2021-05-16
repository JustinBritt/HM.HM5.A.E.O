﻿namespace HM.HM5.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            ImmutableList<IlIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int value)
        {
            return this.Value
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}
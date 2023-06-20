﻿namespace HM.HM5.A.E.O.Classes.Indices
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            RedBlackTree<INullableValue<int>, IlIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}
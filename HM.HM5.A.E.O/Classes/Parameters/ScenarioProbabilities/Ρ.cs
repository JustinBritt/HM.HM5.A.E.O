﻿namespace HM.HM5.A.E.O.Classes.Parameters.ScenarioProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM5.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    internal sealed class Ρ : IΡ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ρ(
            RedBlackTree<IΛIndexElement, IΡParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IΛIndexElement, IΡParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement)
        {
            return this.Value[ΛIndexElement].Value.Value.Value;
        }
    }
}
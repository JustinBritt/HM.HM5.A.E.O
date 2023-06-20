﻿namespace HM.HM5.A.E.O.Classes.Parameters.SurgeonLengthOfStayMaximums
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM5.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;

    internal sealed class L : IL
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public L(
            RedBlackTree<IsIndexElement, ILParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, ILParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}
﻿namespace HM.HM5.A.E.O.Classes.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class VarianceΦ : IVarianceΦ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceΦ(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IVarianceΦResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IVarianceΦResultElement>>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IVarianceΦResultElement>> firstInnerTree = this.Value[sIndexElement];

            RedBlackTree<IΛIndexElement, IVarianceΦResultElement> secondInnerTree;

            bool result = firstInnerTree.TryGetValue(
                lIndexElement,
                out secondInnerTree);

            if (result)
            {
                return secondInnerTree[ΛIndexElement].Value;
            }
            else
            {
                return 0m;
            }
        }
    }
}
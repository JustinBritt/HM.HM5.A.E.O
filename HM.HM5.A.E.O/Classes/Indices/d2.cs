namespace HM.HM5.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;

    internal sealed class d2 : Id2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2(
            RedBlackTree<INullableValue<int>, Id2IndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, Id2IndexElement> Value { get; }

        public Id2IndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}
namespace HM.HM5.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;
    
    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Classes.Indices;
    using HM.HM5.A.E.O.Interfaces.Comparers;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class d1Factory : Id1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Factory()
        {
        }

        public Id1 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value)
        {
            Id1 index = null;

            try
            {
                index = new d1(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, Id1IndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value)
        {
            RedBlackTree<INullableValue<int>, Id1IndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, Id1IndexElement>(
                nullableValueintComparer);

            foreach (Id1IndexElement d1IndexElement in value)
            {
                redBlackTree.Add(
                    d1IndexElement.Value,
                    d1IndexElement);
            }

            return redBlackTree;
        }
    }
}
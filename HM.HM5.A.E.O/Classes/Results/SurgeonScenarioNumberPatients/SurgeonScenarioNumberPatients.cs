﻿namespace HM.HM5.A.E.O.Classes.Results.SurgeonScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.Interfaces.IndexElements;

    internal sealed class SurgeonScenarioNumberPatients : ISurgeonScenarioNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatients(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonScenarioNumberPatientsResultElement> Value { get; }

        private int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Is s,
            IΛ Λ)
        {
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> outerRedBlackTree = new(
                new HM.HM5.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<int>> innerRedBlackTree = new(
                    new HM.HM5.A.E.O.Classes.Comparers.NullableValueintComparer());

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsint(
                                sIndexElement,
                                ΛIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}
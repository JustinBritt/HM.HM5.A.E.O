﻿namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM5.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization.Configuration;

    public interface IDependenciesAbstractFactory
    {
        IConfigurationFactory CreateConfigurationFactory();

        IModelFactory CreateModelFactory();

        IModelScopeFactory CreateModelScopeFactory();

        INullableValueFactory CreateNullableValueFactory();

        IObjectiveFactory CreateObjectiveFactory();

        IRedBlackTreeFactory CreateRedBlackTreeFactory();

        ISolverFactory CreateSolverFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();

        IVariableFactory CreateVariableFactory();

        IVariableCollectionFactory CreateVariableCollectionFactory();
    }
}
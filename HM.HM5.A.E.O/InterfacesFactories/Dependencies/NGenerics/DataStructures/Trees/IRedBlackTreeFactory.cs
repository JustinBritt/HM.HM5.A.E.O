﻿namespace HM.HM5.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees
{
    using System.Collections.Generic;

    using global::NGenerics.DataStructures.Trees;

    public interface IRedBlackTreeFactory
    {
        RedBlackTree<TKey, TValue> Create<TKey, TValue>();

        RedBlackTree<TKey, TValue> Create<TKey, TValue>(
            IComparer<TKey> comparer);
    }
}
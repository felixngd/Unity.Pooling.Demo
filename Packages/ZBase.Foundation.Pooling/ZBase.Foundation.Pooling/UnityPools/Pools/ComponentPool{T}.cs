﻿using System;

namespace ZBase.Foundation.Pooling.UnityPools
{
    [Serializable]
    public class ComponentPool<T>
        : ComponentPool<T, ComponentPrefab<T>>
        where T : UnityEngine.Component
    {
        public ComponentPool()
            : base()
        { }

        public ComponentPool(ComponentPrefab<T> prefab)
            : base(prefab)
        { }

        public ComponentPool(UniqueQueue<int, T> queue)
            : base(queue)
        { }

        public ComponentPool(UniqueQueue<int, T> queue, ComponentPrefab<T> prefab)
            : base(queue, prefab)
        { }
    }
}

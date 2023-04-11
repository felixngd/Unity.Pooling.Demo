﻿using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace ZBase.Foundation.Pooling.UnityPools
{
    [Serializable]
    public class ComponentPrefab<T> : UnityPrefab<T, T>
        where T : UnityEngine.Component
    {
        protected override async UniTask<T> Instantiate(
              T source
            , Transform parent
            , CancellationToken cancelToken
        )
        {
            T instance;

            if (parent)
                instance = UnityEngine.Object.Instantiate(Source, parent);
            else
                instance = UnityEngine.Object.Instantiate(Source);

            return await UniTask.FromResult(instance);
        }

        public override void Release(T instance)
        {
            if (instance)
                UnityEngine.Object.Destroy(instance.gameObject);
        }
    }
}
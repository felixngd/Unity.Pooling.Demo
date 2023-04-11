﻿using System;
using System.Runtime.CompilerServices;

namespace ZBase.Foundation.Pooling
{
    public readonly struct Disposable<T> : IDisposable
    {
        public readonly T Instance;

        private readonly IReturnable<T> _pool;

        internal Disposable(IReturnable<T> pool, T instance)
        {
            _pool = pool;
            Instance = instance;
        }

        public void Dispose()
        {
            _pool?.Return(Instance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator T(in Disposable<T> poolable)
            => poolable.Instance;
    }
}
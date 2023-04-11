﻿using System.Runtime.CompilerServices;
using ZBase.Foundation.Pooling;

namespace System.Collections.Generic.Pooling
{
    public class ListPool<T>
        : Pool<List<T>
        , DefaultConstructorInstantiator<List<T>>>
    {
        public ListPool()
            : base()
        { }

        public ListPool(UniqueQueue<List<T>> queue)
            : base(queue)
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void ReturnPreprocess(List<T> instance)
            => instance.Clear();
    }
}

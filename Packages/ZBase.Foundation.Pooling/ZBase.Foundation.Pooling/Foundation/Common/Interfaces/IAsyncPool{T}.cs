﻿namespace ZBase.Foundation.Pooling
{
    public interface IAsyncPool<T> : IPool, IAsyncRentable<T>, IReturnable<T>, IReleaseInstances<T>, ICountable
    {
    }
}

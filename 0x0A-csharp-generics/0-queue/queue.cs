using System;

class Queue<T>
{
    /// <summary>Check and return the type of the Queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
using System;

class Shape
{
    /// <summary>Throws an NotImplementedException with the message Area() is not implemented for now.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
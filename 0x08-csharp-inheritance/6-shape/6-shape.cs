using System;

class Shape
{
    /// <summary>Throws an NotImplementedException with the message Area() is not implemented for now.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets or set the value of width</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>Gets or set the value of height</summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
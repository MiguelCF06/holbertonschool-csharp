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

    /// <summary>Returns the area of the rectangle.</summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>Returns a string representation of the rectangle.</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

class Square : Rectangle
{
    private int size;

    /// <summary>Gets or set the value of size</summary>    
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
                size = value;
        }
    }
}
using System;

///<summary>Base class</summary>
public abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        string valueToReturn = $"{this.name} is a {this.GetType().ToString()}";
        return valueToReturn;
    }
}
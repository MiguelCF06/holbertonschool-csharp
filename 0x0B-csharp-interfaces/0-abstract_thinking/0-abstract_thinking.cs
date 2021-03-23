using System;

///<summary>Base class</summary>
public abstract class Base
{
    ///<summary>The name of the object</summary>
    public string name { get; set; }

    ///<summary>Overrides the default ToString function to return what I want</summary>
    public override string ToString()
    {
        string valueToReturn = $"{this.name} is a {this.GetType().ToString()}";
        return valueToReturn;
    }
}
using System;

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

///<summary>A test class that inherits from base and all the created interfaces</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get; set;}

    ///<summary>Happens when the object wants to interact with something</summary>    
    public void Interact()
    {

    }

    ///<summary>Happens when the object breaks</summary>
    public void Break()
    {

    }

    ///<summary>Happens when the object collect something</summary>
    public void Collect()
    {
        
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability {get; set;}
    void Break();
}

interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

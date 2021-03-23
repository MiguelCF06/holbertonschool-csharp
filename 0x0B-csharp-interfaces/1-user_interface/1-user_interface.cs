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

///<summary>A test class that inherits from base and all the created interfaces</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>The durability of the object</summary>
    public int durability {get; set;}

    ///<summary>The state of the object (collected/not collected)</summary>
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

/// <summary>Interactive interface</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>Breakable interface</summary>
interface IBreakable
{
    int durability {get; set;}
    void Break();
}

/// <summary>Collectable interface</summary>
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

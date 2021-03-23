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

class Door : Base, IInteractive
{
    ///<summary>The constructor of the Door where sets its name</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary>Happens when the object wants to interact with something in this case is the Door class</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
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

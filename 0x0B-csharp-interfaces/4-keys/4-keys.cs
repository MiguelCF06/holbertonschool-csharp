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

class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>The durability of the object</summary>
    public int durability {get; set;}
    ///<summary>Check if the object is a quest item or not</summary>
    public bool isQuestItem {get; set;}

    ///<summary>The constructor of the Decoration where sets its name, durability and if it is a quest item</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        else
            this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>Happens when the object interacts with something</summary>
    public void Interact()
    {
        if (this.durability <= 0)
            Console.WriteLine($"The {this.name} has been broken.");
        else if (this.isQuestItem)
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        else if (!this.isQuestItem)
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
    }

    ///<summary>Happens when the object breaks</summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        else if (this.durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        else if (this.durability < 0)
            Console.WriteLine($"The {this.name} is already broken.");
    }
}

class Key : Base, ICollectable
{
    ///<summary>Check if the current key was already collected</summary>
    public bool isCollected {get; set;}

    ///<summary>The constructor that sets the name of the object and sets the state of that key (collected/not collected)</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary>Happens when the objects wants to collect or grab something</summary>
    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {this.name}.");
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
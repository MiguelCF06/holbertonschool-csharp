using System;

/// <summary>Delegate that calculate the health of the player when Heals or Receive damage, takes as parameters the <paramref name="amount" /> of Heal or Damage</summary>
public delegate void CalculateHealth(float amount);

class Player
{
    private string name {get; set;}
    private float maxHp {get; set;}
    private float hp {get; set;}

    /// <summary>The constructor of the class Player and takes two parameters <paramref name="name"/> that is the name of the player
    /// and <paramref name="maxHp"/> that is the maximum Health points of the player</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>Print the health stats of the player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>Print the the amount of damage that receive the player.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine($"{this.name} takes 0 damage!");
        else
            Console.WriteLine($"{this.name} takes {damage} damage!");
        
    }

    /// <summary>Print the the amount of heal that receive the player.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine($"{this.name} heals 0 HP!");
        else
            Console.WriteLine($"{this.name} heals {heal} HP!");
        
    }
}
using System;

/// <summary>Delegate that calculate the health of the player when Heals or Receive damage, takes as parameters the <paramref name="amount" /> of Heal or Damage</summary>
delegate void CalculateHealth(float amount);

/// <summary>Determines the strength of attack modifer. </summary>
/// <param name="baseValue">Normal attack.</param>
/// <param name="modifier">Modifier to apply to baseValue.</param>
delegate float CalculateModifier(float baseValue, Modifier modifier);

enum Modifier
{
    Weak,
    Base,
    Strong,
}

class Player
{
    private string name {get; set;}
    private float maxHp {get; set;}
    private float hp {get; set;}
    private string status {get; set;}

    public event EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>Print the health stats of the player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>Print the the amount of damage that receive the player.</summary>
    public void TakeDamage(float damage)
    {
        float newHp;
        if (damage < 0)
            Console.WriteLine($"{this.name} takes 0 damage!");
        else
            Console.WriteLine($"{this.name} takes {damage} damage!");

        newHp = hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>Print the the amount of heal that receive the player.</summary>
    public void HealDamage(float heal)
    {
        float newHp;
        if (heal < 0)
            Console.WriteLine($"{this.name} heals 0 HP!");
        else
            Console.WriteLine($"{this.name} heals {heal} HP!");

        newHp = hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>Check the new amount of hp after (Heal/Damage) and sets it to the Actual hp of the player.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        HPCheck.Invoke(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>Apply a modifier to the amount of (Heal/Damage) Depending of it is (Weak, Base or Strong)</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= maxHp / 2 && e.currentHp <= maxHp)
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= maxHp / 4 && e.currentHp <= maxHp / 2)
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0 && e.currentHp <= maxHp / 4)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }
}

class CurrentHPArgs : EventArgs
{
    public float currentHp {get; set;}

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
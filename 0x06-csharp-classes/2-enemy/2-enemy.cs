using System;

namespace Enemies
{
    /// <summary>Empty public class that defines a Zombie</summary>
    public class Zombie
    {
        /// <summary>The amount of health of the Zombie</summary>
        public int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
    }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class and takes as 
        /// parameter<paramref name="value"/> as the amount of health</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}
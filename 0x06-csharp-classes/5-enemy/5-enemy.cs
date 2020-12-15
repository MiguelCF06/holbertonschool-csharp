using System;

namespace Enemies
{
    /// <summary>A class that defines a Zombie</summary>
    class Zombie
    {
        int health;
        string name = "(No name)";

        /// <summary>Gets or sets the name of the Zombie.</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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

        /// <summary>Returns the amount of health of the Zombie.</summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>Returns a string representation of the Zombie Object.</summary>
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
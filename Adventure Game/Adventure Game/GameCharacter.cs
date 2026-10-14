using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    internal abstract class GameCharacter
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _health;

        protected int Health
        {
            get { return _health; }
            set
            {
                if (value >= 0 && value <= 100)
                    _health = value;
                else
                    throw new ArgumentOutOfRangeException("Health must be between 0 and 100.");
            }
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Heal()
        {
            Health += 10;
            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }


    }
}

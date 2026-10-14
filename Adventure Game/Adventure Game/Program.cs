using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior warrior = new Warrior("Alexx", 80);
            Wizard wizard = new Wizard("Lunaa", 70);

            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter c in characters)
            {
                Console.WriteLine($"{c.Name} enters the game!");
                c.UseSpecialAbility();
            }
            Console.WriteLine();

            warrior.TakeDamage(10);
            Console.WriteLine();

            warrior.Heal();
            Console.WriteLine();

            warrior.Heal(15);
            Console.WriteLine();

            wizard.TakeDamage(10);
            Console.WriteLine();

            HealthPotion potion = new HealthPotion("Small Potion");
            potion.Collect();
            Console.WriteLine();

            potion.Use(wizard, "15");
            Console.WriteLine();

            potion.Use(wizard, "abc");
            Console.WriteLine();
        }
    }
}

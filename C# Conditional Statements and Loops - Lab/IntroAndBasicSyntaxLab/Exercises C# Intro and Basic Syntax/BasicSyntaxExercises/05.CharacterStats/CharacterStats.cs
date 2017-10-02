using System;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            string health = new string('|', currentHealth);
            int dots = maxHealth - currentHealth;
            string notHealth = new string('.', dots);
            Console.Write($"Health: |{health}");
            Console.WriteLine($"{notHealth}|");

            string energy = new string('|', currentEnergy);
            int energyDots = energyMax - currentEnergy;
            string eDot = new string('.', energyDots);
            Console.Write($"Energy: |{energy}");
            Console.WriteLine($"{eDot}|");
        }
    }
}

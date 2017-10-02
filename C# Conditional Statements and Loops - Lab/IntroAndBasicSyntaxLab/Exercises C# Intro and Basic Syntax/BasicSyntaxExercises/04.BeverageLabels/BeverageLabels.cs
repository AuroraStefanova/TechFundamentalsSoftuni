using System;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string nameProduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());// per 100ml
            double energy = double.Parse(Console.ReadLine());// per 100ml
            double sugar = double.Parse(Console.ReadLine()); //per 100ml

            double perQuantityEnergy = (volume * energy) / 100;
            double sugarPerVolume = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {nameProduct}:");
            Console.WriteLine($"{perQuantityEnergy}kcal, {sugarPerVolume}g sugars");
        }
    }
}

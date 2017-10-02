using System;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double mp = Math.Round(((width * height) / 1000000), 1);
            Console.WriteLine($"{width}x{height} => {mp}MP");
        }
    }
}

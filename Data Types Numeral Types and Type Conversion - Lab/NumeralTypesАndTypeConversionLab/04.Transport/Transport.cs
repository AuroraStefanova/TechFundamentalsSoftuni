using System;

namespace _04.Transport
{
    class Transport
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            double vehicles = 24;

            double all = Math.Ceiling(n / vehicles);
            Console.WriteLine(all);
        }
    }
}

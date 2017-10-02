using System;
using System.Linq;
namespace _03.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            int minElement = elements.Min();
            Console.WriteLine(minElement);

        }
    }
}

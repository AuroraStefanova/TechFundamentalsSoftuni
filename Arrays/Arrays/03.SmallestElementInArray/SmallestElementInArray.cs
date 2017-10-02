using System;
using System.Linq;

namespace _03.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int smallest = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNUmber = numbers[i];
                if (currentNUmber < smallest)
                {
                    smallest = currentNUmber;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}

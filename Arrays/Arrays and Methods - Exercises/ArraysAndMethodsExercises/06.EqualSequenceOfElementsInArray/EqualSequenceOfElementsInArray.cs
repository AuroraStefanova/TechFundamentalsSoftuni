using System;
using System.Linq;

namespace _06.EqualSequenceOfElementsInArray
{
    class EqualSequenceOfElementsInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}

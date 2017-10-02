using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._01.SumAdjacentNumNAKOV
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = i - 2;//1h.03m 
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

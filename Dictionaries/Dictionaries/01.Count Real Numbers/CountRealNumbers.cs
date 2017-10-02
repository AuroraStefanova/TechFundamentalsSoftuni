using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var sorted = new SortedDictionary<double, int>();

            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var num in numbers)
            {
                if (!sorted.ContainsKey(num))
                {
                    sorted[num] = 0;
                }
                sorted[num]++;

            }
            foreach (var kvp in sorted)
            {
                double key = kvp.Key;
                int value = kvp.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}

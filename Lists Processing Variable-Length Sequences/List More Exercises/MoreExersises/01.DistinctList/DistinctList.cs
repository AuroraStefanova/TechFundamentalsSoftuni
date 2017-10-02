using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var newList = new List<int>();

            foreach (var number in numbers.Distinct())
            {
                newList.Add(number);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}

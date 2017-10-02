using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumber
{
    class Program
    {
        static void Main()
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            number.Sort();
            Console.WriteLine(string.Join(" <= ", number));
        }
    }
}

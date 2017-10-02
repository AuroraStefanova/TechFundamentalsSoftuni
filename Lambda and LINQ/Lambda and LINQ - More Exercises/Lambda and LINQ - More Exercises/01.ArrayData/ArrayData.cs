using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ArrayData
{
    class ArrayData
    {
        static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            double averageSum = inputLine.Average();

            var newList = inputLine.Where(x => x >= averageSum).ToList();

            if(command == "Min")
            {
                int min = newList.Min();
                Console.WriteLine(min);
            }
            else if(command == "Max")
            {
                int max = newList.Max();
                Console.WriteLine(max);
            }
            else if(command == "All")
            {
                newList.Sort();
                Console.WriteLine($"{string.Join(" ", newList)}");
            }
        }
    }
}

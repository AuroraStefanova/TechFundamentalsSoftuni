using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToList();
            //var text = new List<string> { "abc", "abc", "test", "123", "123", "test" };

            text.Sort();

            Console.WriteLine(string.Join(" ", text));

        }
    }
}

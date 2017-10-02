using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bothLines = firstLine.Select(el => el).Concat(secondLine);
            //r (int i = 0; i < length; i++)
            /// first[2 4 4 3 9 ]
            // second [ 4 1 3 2 7 ]
            //
            //
            Console.WriteLine(bothLines);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var sequences = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();



            for (int i = 0; i < N; i++)
            {
                var numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();


            }
        }
    }
}

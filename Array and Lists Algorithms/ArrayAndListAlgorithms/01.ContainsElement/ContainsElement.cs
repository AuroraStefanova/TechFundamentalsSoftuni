using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ContainsElement
{
    class ContainsElement
    {
        static void Main()
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < number.Count; i++)
            {
                if (number.Contains(n))
                {
                    Console.WriteLine("yes");
                    return;
                }

            }
            Console.WriteLine("no");

        }
    }
}

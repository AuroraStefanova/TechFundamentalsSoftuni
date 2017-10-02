using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int count = 0;
            int transportAt = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] != 0)
                {
                    transportAt = numbers[i];
                    numbers[i] = 0;
                    i = transportAt;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

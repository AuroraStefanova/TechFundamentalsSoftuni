﻿using System;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n*2; i+=2)
            {
                sum += i;
                Console.WriteLine(i);

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int n = int.Parse(Console.ReadLine());
                
                BigInteger result = 1;

                for (int i = n; i >= 1; i--)
                {
                    result *= i;
                }
                Console.WriteLine(result);
            }

        }
    }
}

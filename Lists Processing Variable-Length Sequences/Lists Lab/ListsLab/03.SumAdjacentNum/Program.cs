using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentNum
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeterCharArray = " ".ToCharArray();

            var num = Console.ReadLine()
                .Split( delimeterCharArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();// 5 8 

            for (int i = 0; i < num.Count -1; i++)
            {
                double first = num[i];
                double second = num[i + 1];

                if(first == second)
                {
                    num[i] = num[i] * 2;
                    num.RemoveAt(i + 1);
                    i -= 2;

                    if( i < -1)
                    {
                        i = -1;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}

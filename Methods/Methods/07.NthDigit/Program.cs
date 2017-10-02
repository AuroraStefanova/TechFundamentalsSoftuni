using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            long result = NthDigit(number, digit);
            Console.WriteLine(result);
        }
        static long NthDigit(long num, int index)
        {
            //long result = 0;
            for (long i = 1; i < num ; i++)
            {
                if(index == i)
                {
                    num = num % 10;
                    break;
                }
                num = num / 10;

            }
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string result = ToBase(num, toBase);
            Console.WriteLine(result);
        }
        static string ToBase(int number, int bases)
        {
            string result = "";
            while (number != 0)
            {
                int remainder = number % bases;
                result = remainder + result;
                number /= bases;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MethodwithParameters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

        }
        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}

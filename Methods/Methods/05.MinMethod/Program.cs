using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinMethod
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = GetMin(first, second, third);
            Console.WriteLine(min);
        }
        static int GetMin(int a,int b,int c)
        {
            int min = a;

            if (a > b)
            {
                min = b;
                if (b > c)
                {
                    min = c;
                }
            }
            else if(a > c)
            {
                min = c;
                if (c > b)
                {
                    min = b;
                }
            }
            return min;
        }
    }
}

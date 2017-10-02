using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            long Y = long.Parse(Console.ReadLine());
            long percent = (N * 50) / 100;

            Console.WriteLine(percent);
        }
    }
}

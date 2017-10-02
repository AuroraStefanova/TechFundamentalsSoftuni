using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            var driver = Console.ReadLine().Split(' ').ToList();
            double[] trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            long[] checkpoint = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        }
    }
}

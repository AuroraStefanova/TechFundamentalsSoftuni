using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044.SortArr
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            num.Sort();
            Console.WriteLine(string.Join(" ", num));
        }
    }
}

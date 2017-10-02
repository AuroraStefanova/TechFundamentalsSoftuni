using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int N = int.Parse(Console.ReadLine());
            var result = new List<int>();
            numbers.Sort();
            numbers.Reverse();

            
        }
    }
}

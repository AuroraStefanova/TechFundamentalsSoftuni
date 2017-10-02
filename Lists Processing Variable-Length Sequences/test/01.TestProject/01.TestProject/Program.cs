using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();


            double multiply = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= multiply;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

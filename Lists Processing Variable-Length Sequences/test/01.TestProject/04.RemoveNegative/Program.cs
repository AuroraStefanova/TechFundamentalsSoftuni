using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RemoveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] >= 0)
                {
                    secondList.Add(number[i]);
                }
            }
            secondList.Reverse();
            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}

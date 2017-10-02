using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i % 2 != 0)
                {
                    if(numbers[i] % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {numbers[i]}");
                    }
                }
            }
        }
    }
}

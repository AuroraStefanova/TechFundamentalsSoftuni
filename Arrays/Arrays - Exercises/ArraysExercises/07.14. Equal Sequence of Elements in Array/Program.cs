using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._14.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}

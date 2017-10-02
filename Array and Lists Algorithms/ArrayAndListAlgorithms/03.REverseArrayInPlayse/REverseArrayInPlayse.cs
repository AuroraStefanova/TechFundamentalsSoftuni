using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.REverseArrayInPlayse
{
    class REverseArrayInPlayse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count/2; i++)// 6 1 1
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;

            }
            
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}

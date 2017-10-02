using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0111.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            //var numbers = new List<int> {7, 8, 9, 7, 2, 3, 4, 1, 2};
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        i = 0;
                        //Console.WriteLine(string.Join(" ", numbers));
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

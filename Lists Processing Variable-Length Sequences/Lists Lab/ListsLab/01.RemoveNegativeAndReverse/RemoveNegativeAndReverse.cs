using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Reverse()
                .ToList();

            numbers.RemoveAll(x => x < 0);// list numbers remove  < 0 


            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }

            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}

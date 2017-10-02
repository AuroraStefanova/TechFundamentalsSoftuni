using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var list = input.Split(' ').Select(int.Parse).ToList();
            input = Console.ReadLine();

            while (input != "end")
            {
 
                var currentNum = int.Parse(input);
                var firstDigit = input[0].ToString();
                var index = int.Parse(firstDigit);

                list.Insert(index, currentNum);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();
            for (int i = 1; i < numbers.Count-1; i++)
            {//     2      =     3    +   8
             //
                int previousNum = numbers[i - 1];
                int currentNum = numbers[i];
                int nextNum = numbers[i + 1];
                if(currentNum == nextNum + previousNum)
                {
                    numbers.RemoveAt(numbers[i-1]);
                    numbers.RemoveAt(numbers[i+1]);
                    
                    
                }
                Console.WriteLine(string.Join(" ", numbers));
                //if(numbers[i] == numbers[i- 1]+ numbers[i + 1])
                // {
                //    numbers.RemoveAt(numbers[numbers[i]]);
                //    numbers.RemoveAt(numbers[numbers[i+1]]);
                //     
                //     Console.WriteLine( string.Join(" ", result));
                // }
            }

        }
    }
}

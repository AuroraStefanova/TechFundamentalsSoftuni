using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var result = new List<int>();

            for (int i = 0; i < inputLine.Count; i++)
            {
                if(inputLine[i] == inputLine[i + 1])
                {
                    inputLine[i] = inputLine[i] + inputLine[i + 1];
                    inputLine.RemoveAt(inputLine[i + 1]);

                    i = i - 2;
                    
                }

            }
            Console.WriteLine($"{string.Join(" ", inputLine)}");
        }
    }
}

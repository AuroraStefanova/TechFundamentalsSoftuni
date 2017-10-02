using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numners = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int smallest = numners.Max();

            for (int i = 0; i < numners.Count; i++)
            {
                if(numners[i] < smallest)
                {
                    smallest = numners[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}

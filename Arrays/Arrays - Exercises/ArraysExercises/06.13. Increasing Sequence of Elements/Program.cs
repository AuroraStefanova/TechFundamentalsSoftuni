using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._13.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < listNum.Count - 1; i++)
            {
                if(listNum[i] > listNum[i + 1])
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
           // int num = int.Parse(Console.ReadLine());
            List<int> newList = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());

                newList.Add(numToAdd);

            }
            Console.WriteLine("Sum = " + newList.Sum());
            Console.WriteLine("Min = "+ newList.Min());
            Console.WriteLine("Max = "+ newList.Max());
            Console.WriteLine("Average = " + newList.Average());
        }
    }
}

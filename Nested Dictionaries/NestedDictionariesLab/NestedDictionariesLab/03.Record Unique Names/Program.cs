using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> inputNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                inputNames.Add(input);
            }
            foreach (var kvp in inputNames)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}

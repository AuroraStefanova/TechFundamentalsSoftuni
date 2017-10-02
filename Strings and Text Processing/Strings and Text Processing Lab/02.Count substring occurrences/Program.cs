using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string term = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(term);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(term, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}

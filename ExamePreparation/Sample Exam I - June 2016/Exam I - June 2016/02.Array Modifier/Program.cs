using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var Element = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string inputLine = Console.ReadLine();
            var result = new List<long>();

            while (inputLine != "end")
            {
                var token = inputLine.Split(' ').ToArray();
                string action = token[0];

                if (action == "decrease")
                {
                    for (int i = 0; i < Element.Count; i++)
                    {
                        Element[i]--;
                    }
                }
                else
                {
                    int firstIndex = int.Parse(token[1]);
                    int secondIndex = int.Parse(token[2]);
                    
                    if (action == "swap")
                    {

                        long index = Element[firstIndex];
                        Element[firstIndex] = Element[secondIndex];
                        Element[secondIndex] = index;

                    }
                    else if (action == "multiply")
                    {
                        Element[firstIndex] = Element[firstIndex] * Element[secondIndex];
                    }
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join(", ", Element)}");
        }
    }
}


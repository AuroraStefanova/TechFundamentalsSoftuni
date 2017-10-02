using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var removedElements = new List<long>();
            long removed = 0;
            while (inputLine.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                
                if(index < 0)
                {
                    index = 0;
                    removed = inputLine[index];
                    removedElements.Add(removed);
                    inputLine.RemoveAt(index);
                    inputLine.Insert(index, inputLine.Last());

                }
                else if(index >=0 && index > inputLine.Count -1)
                {
                    index = inputLine.Count - 1;
                    removed = inputLine[index];
                    removedElements.Add(removed);
                    inputLine.RemoveAt(inputLine.Count - 1);
                    inputLine.Add(inputLine[0]);
                }
                else
                {
                    removed = inputLine[index];
                    removedElements.Add(removed);
                    inputLine.RemoveAt(index);
                }

                for (int i = 0; i < inputLine.Count; i++)
                {
                    if(inputLine[i] <= removed)
                    {
                        inputLine[i] += removed;
                    }
                    else if(inputLine[i] > removed)
                    {
                        inputLine[i] -= removed;
                    }
                }      
            }

            Console.WriteLine(removedElements.Sum());
        }
    }
}

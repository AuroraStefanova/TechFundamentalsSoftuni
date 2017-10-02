using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                index = inputLine[i];

                if(i != 0 && i != inputLine.Count - 1)
                {
                    int sum = inputLine[i - 1] + inputLine[i + 1];

                    if(index == sum)
                    {
                        inputLine.RemoveAt(i + 1);
                        inputLine.RemoveAt(i - 1);

                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                if(inputLine[i] != 0)
                {
                    var wormhole = inputLine[i];
                    inputLine[i] = 0;
                    i = wormhole;
                }
                count++;
            }
            Console.WriteLine(count);

        }
    }
}

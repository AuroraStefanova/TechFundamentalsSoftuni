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
            var inputline = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 0;
            for (int i = 0; i < inputline.Count; i++)
            {
                if(inputline[i] != 0)
                {
                    var wormhow = inputline[i];
                    inputline[i] = 0;

                    i = wormhow;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

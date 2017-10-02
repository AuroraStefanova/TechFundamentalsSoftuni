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
            var num = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToList();

            int count = 0;
            for (int i = 0; i < num.Count; i++)
            {
                if(num[i] != 0)
                {
                    var wormhole = num[i];
                    num[i] = 0;
                    i = wormhole;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

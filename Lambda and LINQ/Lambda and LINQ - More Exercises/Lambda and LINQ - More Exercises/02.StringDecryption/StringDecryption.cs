using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var skup = arr[0];
            var take = arr[1];

            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = secondLine.Where(x => x >= 65 && x <= 90 ).Skip(skup)
                .Take(take).Select(x => (char) x).ToList();
            


            Console.WriteLine($"{string.Join("", result) }");
        }
    }
}

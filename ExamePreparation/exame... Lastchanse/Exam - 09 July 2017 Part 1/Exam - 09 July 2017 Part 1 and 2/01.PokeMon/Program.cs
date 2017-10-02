using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int PokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int count = 0;
            double howfPower = (PokePower * 50) / 100;

            while (PokePower >= distance)
            {
                if( PokePower != howfPower)
                {
                    PokePower -= distance;
                    count++;
                }
                else if( PokePower == howfPower)
                {
                    PokePower /= Y;
                }
            }
            Console.WriteLine(PokePower);
            Console.WriteLine(count);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine());  //M
            int exhaustionFactor = int.Parse(Console.ReadLine());//y
            int holfPokePower = (pokePower * 50) / 100;
            int count = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;

                if(exhaustionFactor != 0 && exhaustionFactor !=1)
                {
                    if(pokePower == holfPokePower)
                    {
                        pokePower /= exhaustionFactor;
                        continue;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}

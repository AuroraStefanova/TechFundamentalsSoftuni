using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornet = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            //var power = hornet.Sum();
            //var sum = 0;

            for (int i = 0; i < beehives.Count; i++)
            {

                if (beehives[i] < hornet.Sum())
                {
                    beehives.RemoveAt(i);
                    i--;
                }

                else
                {
                    beehives[i] -= hornet.Sum();
                    if (beehives[i] <= 0)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                    hornet.RemoveAt(0);
                }
                if (hornet.Count == 0 || beehives.Count == 0)
                {
                    break;
                
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", beehives)}");
            }

            else// (beehives.Count <= 0 || (beehives.Count == 1 && beehives[0] == 0))// beehives.Any(x => x >0)
                                                                                 //var res = beehivers.Where( x=> x >0
            {
                Console.WriteLine($"{string.Join(" ", hornet)}");

            }
        }
    }
}

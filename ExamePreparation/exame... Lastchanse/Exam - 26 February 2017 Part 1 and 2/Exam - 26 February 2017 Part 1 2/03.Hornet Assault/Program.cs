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
            var beehaves = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehaves.Count; i++)
            {

                if(beehaves[i] < hornets.Sum())
                {
                    beehaves.RemoveAt(i);
                    i--;
                }

                else
                {
                    beehaves[i] -= hornets.Sum();

                    if(beehaves[i] <= 0)
                    {
                        beehaves.RemoveAt(i);
                        i--;

                    }
                    //else if( beehaves[i] == hornets.Sum())
                    //{
                    //    beehaves.RemoveAt(i);
                    //    hornets.RemoveAt(0);
                    //}

                        hornets.RemoveAt(0);

                    if(beehaves.Count == 0 || hornets.Count == 0)
                    {
                        break;
                    }
                }
            }
            if( beehaves.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", beehaves)}");
            }
            else
            {
                Console.WriteLine($"{string.Join( " ", hornets)}");
            }
        }
    }
}

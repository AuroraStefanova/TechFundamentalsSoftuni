using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(' ').ToList();

            var trackLayout = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();

            var checkpoint = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            var result = new Dictionary<string, double>();

            double number = 0;
            for (int i = 0; i < drivers.Count; i++)
            {
                if (!result.ContainsKey(drivers[i]))
                {
                    result[drivers[i]] = 0;
                }
                char firstLetter = drivers[i][0];
                number = (int)firstLetter;
                Console.WriteLine(number);

                for (int j = 0; j < checkpoint.Count; j++)
                {

                    for (int k = 0; k < trackLayout.Count -1 ; k++)
                    {
                        double index = trackLayout[k];
                        if (checkpoint[j] == k)
                        {
                            number += index;
                            continue;
                        }
                        else if(checkpoint[j] != j)
                        {
                            number -= index;
                            continue;
                        }
                    }
                    //result[drivers[i]] = number;
                }
                result[drivers[i]] = number;
            }
            foreach (var item in result)
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} - fuel left {item.Value:f2}");
                }

                else
                {
                    Console.WriteLine($"{item.Key} - reached 0");
                }

               
            }
        }
    }
}

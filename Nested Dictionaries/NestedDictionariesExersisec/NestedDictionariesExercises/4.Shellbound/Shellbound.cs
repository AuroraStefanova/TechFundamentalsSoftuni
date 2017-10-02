using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Shellbound
{
    class Shellbound
    {
        static void Main()
        {

            var input = Console.ReadLine();
            Dictionary<string, HashSet<int>> shellBond = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');
                string city = tokens[0];
                var numberShells = int.Parse(tokens[1]);

                if (!shellBond.ContainsKey(city))
                {
                    shellBond[city] = new HashSet<int>();
                }
                shellBond[city].Add(numberShells);

                input = Console.ReadLine();
            }
            

            foreach (var city in shellBond)
            {
                var selected = city.Value;
                //(sum of shells) – ((sum of shells) / (count of shells))
                Console.Write($"{city.Key} -> ");
                int sumShells = 0;
                foreach (var kvp in selected)
                {
                    sumShells += kvp;

                }
                double average = (sumShells - (sumShells / selected.Count));
                Console.WriteLine($"{string.Join(", ", selected)} ({average})");
                //Console.Write(average);
                // Console.WriteLine($"{city.Key} -> ,{string.Join(",",city)}, ({average})");


            }
        }
    }
}

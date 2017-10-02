using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Group_Continents__Countries_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            //continents-> country -> city

            int  n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> ContinentsCountriesAndCity = new SortedDictionary<string, SortedDictionary<string, System.Collections.Generic.SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continents = input[0];
                string contries = input[1];
                string city = input[2];

                if (!ContinentsCountriesAndCity.ContainsKey(continents))
                {
                    ContinentsCountriesAndCity[continents] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!ContinentsCountriesAndCity[continents].ContainsKey(contries))
                {
                    ContinentsCountriesAndCity[continents][contries] = new SortedSet<string>();
                }
                ContinentsCountriesAndCity[continents][contries].Add(city);
            }

            foreach (var grupContinentCountriesCity in ContinentsCountriesAndCity)
            {
                Console.WriteLine($"{grupContinentCountriesCity.Key}:");

                foreach (var kvp in grupContinentCountriesCity.Value)
                {
                    Console.WriteLine($"  {kvp.Key} -> {string.Join(", ", kvp.Value)}");
                }
            }
        }
    }
}

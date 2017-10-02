using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var NsaResult = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                var token = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string country = token[0];
                string spyName = token[1];
                int dayService = int.Parse(token[2]);

                if (!NsaResult.ContainsKey(country))
                {
                    NsaResult[country] = new Dictionary<string, int>();

                }
                if (!NsaResult[country].ContainsKey(spyName))
                {
                    NsaResult[country][spyName] = 0;
                }
                NsaResult[country][spyName] = dayService;

                inputLine = Console.ReadLine();
            }

            foreach (var country in NsaResult.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var kvp in country.Value.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"**{kvp.Key} : {kvp.Value}");
                }
            }
        }
    }
}

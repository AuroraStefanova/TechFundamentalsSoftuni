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
            var result = new Dictionary<string, Dictionary<string, double>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                var token = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string countryName = token[0];
                string spyName = token[1];
                double dayInService = double.Parse(token[2]);

                if (!result.ContainsKey(countryName))
                {
                    result[countryName] = new Dictionary<string, double>();
                }
                if (!result[countryName].ContainsKey(spyName))
                {
                    result[countryName][spyName] = 0;
                }
                result[countryName][spyName] = dayInService;


                inputLine = Console.ReadLine();
            }

            foreach (var country in result.OrderByDescending(x => x.Value.Values.Count()))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var kvp in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{kvp.Key} : {kvp.Value}");
                }
            }
        }
    }
}

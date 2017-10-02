using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, decimal>();

            var pattern = @"^[A-Z][a-z]+:\d+\.\d+$";
            var input = Console.ReadLine();

            while (input != "bill")
            {
                var mache = Regex.Matches(input, pattern);

                for (int i = 0; i < mache.Count; i++)
                {
                    var token = mache[i].Value.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                    string product = token[0];
                    decimal price = decimal.Parse(token[1]);


                    if (!result.ContainsKey(product))
                    {
                        result[product] = 0;
                    }
                    result[product] = price;
                }

                 input = Console.ReadLine();
            }

            foreach (var kvp in result.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{kvp.Key} costs {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            Dictionary<string, double> dinerChuse = new Dictionary<string, double>();

            string[] inputLine = Console.ReadLine().Split(' ');

            while (inputLine[0] != "end")
            {
                string product = inputLine[0];
                double price = double.Parse(inputLine[1]);

                if (!dinerChuse.ContainsKey(product))
                {
                    dinerChuse[product] = 0;

                }

                if (dinerChuse[product] == 0)
                {
                    dinerChuse[product] = price;
                }

                else if(price <= dinerChuse[product])
                {
                    dinerChuse[product] = price;
                }

                inputLine = Console.ReadLine().Split(' ');
            }
            var sum = dinerChuse.Values.Sum();

            var result = dinerChuse
                .OrderByDescending(x => x.Value).ThenBy(n => n.Key.Length).ToArray();
            foreach (var kvp in result)
            {
                string product = kvp.Key;
                var price = kvp.Value;


                if(budget >= sum)
                {
                    Console.WriteLine($"{kvp.Key} costs {kvp.Value:F2}");
                }
                else
                {
                    Console.WriteLine("Need more money... Just buy banichka");
                    return;
                }
            }
        }
    }
}

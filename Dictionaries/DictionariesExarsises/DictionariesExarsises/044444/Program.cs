using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044444
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stocks = new Dictionary<string, int>();

            var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();


            while (input[0] != "shopping")
            {
                var product = input[1];
                int quantity = int.Parse(input[2]);

                if (!stocks.ContainsKey(product))
                {
                    stocks[product] = 0;
                }
                stocks[product] += quantity;


                if(input[0] != "exam")
                {


                    //var product = input[1];

                    if (!stocks.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");

                    }

                    if (stocks.ContainsKey(product))
                    {
                        if (product[2] == 0)
                        {
                            Console.WriteLine($"{product} out of stock");
                        }
                        else
                        {
                            stocks[product] -= int.Parse(input[2]);
                        }
                        if (stocks[product] <= 0)
                        {
                            stocks[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

  
            foreach (var kvp in stocks)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                if (value > 0)
                {
                    Console.WriteLine($"{key} -> {value}");
                }
            }
        }
    }

//    
//while (input != "shopping time")
//        {
//            string[] elements = input.Split();
//    string product = elements[1];
//    string lastElement = elements[2];
//    int quantity = 0;
//
//            if (int.TryParse(lastElement, out quantity))
//            {
//                if (!inventory.ContainsKey(product))
//                {
//                    inventory[product] = 0;
//                }
//inventory[product] += quantity;
//            }
//            input = Console.ReadLine();
//        }
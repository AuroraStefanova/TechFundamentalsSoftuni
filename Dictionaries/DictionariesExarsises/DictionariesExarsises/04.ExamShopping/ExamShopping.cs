using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main()
        {
            Dictionary<string, int> stocks = new Dictionary<string, int>();

            var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();


            while (input[0] != "shopping")
            {
                if (input.Equals("exam time"))
                {
                    break;
                }

                var product = input[1];
                int quantity = int.Parse(input[2]);

                if (!stocks.ContainsKey(product))
                {
                    stocks.Add(product, quantity);
                }
                else
                {
                    stocks[product] += quantity;

                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "exam")
            {
                var product = input[1];

                if (!stocks.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");

                    input = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    continue;
                }
                //int num = int.Parse(input[2]);
                //stocks[input[1]] = stocks[input[1]] - num;

                if (stocks.ContainsKey(product))
                {
                    if (product[2] == 0)
                    {
                        Console.WriteLine($"{product}1 out of stock");
                    }

                    if (stocks[product] < 0)
                    {
                        stocks[product] = 0;
                    }
                    else
                    {
                        stocks[product] -= int.Parse(input[2]);
                    }
                }
                input = Console.ReadLine()
                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .ToList();
            }

            foreach (var kvp in stocks)
            {
                string key = kvp.Key;
                int value = kvp.Value;

                if (value != 0)
                {
                    Console.WriteLine($"{key} -> {value}");

                }

            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Append_Lists
{
    class Program
    {
        static void Main()
        {
            var result = new List<string>();

            var inputLine = Console.ReadLine().Split('|').Reverse() .ToList();

            foreach (var item in inputLine)
            {
                List<string> numbers = item.Split(' ').ToList();

                foreach (var value in numbers)
                {
                    if(value != "")
                    {
                        result.Add(value);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

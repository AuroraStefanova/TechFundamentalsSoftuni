using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CamelsBack
{
    class CamelsBack
    {
        static void Main()
        {
            //var city = new List<int>
            //{
            //    12, 45, 61, 34, 21, 345, 62, 11, 94
            //};
            var city = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int camelsBack = int.Parse(Console.ReadLine());

            int count = 0;

            if(city.Count == camelsBack)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", city));
                return;
            }
            
            for (int i = 0; i < city.Count; i++)// while( city.Count > camel)
            {
                if(city.Count == camelsBack)
                {
                    Console.WriteLine($"{count} rounds");
                    Console.WriteLine("remaining: {0}", string.Join(" ", city));
                    return;
                }
                city.RemoveAt(0);
                city.RemoveAt(city.Count - 1);

                count++;
            }
            Console.WriteLine(string.Join(" ", city));

        }
    }
}

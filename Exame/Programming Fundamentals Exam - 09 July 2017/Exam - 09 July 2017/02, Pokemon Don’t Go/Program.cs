using System;
using System.Collections.Generic;
using System.Linq;

namespace _02__Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceOfPokemon =
                //{
                //    4,  5,  3
                //};

                Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < distanceOfPokemon.Count; i++)
            {
                int n = int.Parse(Console.ReadLine());

                var index = distanceOfPokemon.FindIndex(x => x == n);
                if(index >= 0)
                {
                    distanceOfPokemon.RemoveAt(index);
                }

                Console.WriteLine(string.Join(" ", distanceOfPokemon));
                
            }
        }
    }
}

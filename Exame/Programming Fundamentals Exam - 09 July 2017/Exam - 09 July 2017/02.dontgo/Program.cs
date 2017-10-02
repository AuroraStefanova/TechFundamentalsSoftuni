using System;
using System.Collections.Generic;
using System.Linq;

namespace _02__Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PokemonNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int element = 0;
            List<int> RemovedPokemonNumbers = new List<int>();

            while (PokemonNumbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    index = 0;
                    element = PokemonNumbers[index];
                    RemovedPokemonNumbers.Add(element);
                    PokemonNumbers.RemoveAt(index);
                    PokemonNumbers.Insert(index, PokemonNumbers.Last());

                }
                else if (index > PokemonNumbers.Count)
                {
                    index = PokemonNumbers.Count - 1;
                    element = PokemonNumbers[index];
                    RemovedPokemonNumbers.Add(element);
                    PokemonNumbers.RemoveAt(index);
                    PokemonNumbers.Insert(index, PokemonNumbers.First());
                }
                else
                {
                    element = PokemonNumbers[index];
                    RemovedPokemonNumbers.Add(element);
                    PokemonNumbers.RemoveAt(index);
                }

                for (int i = 0; i < PokemonNumbers.Count; i++)
                {
                    if (PokemonNumbers[i] <= element)
                    {
                        PokemonNumbers[i] += element;
                    }
                    else
                    {
                        PokemonNumbers[i] -= element;
                    }
                }
            }

            Console.WriteLine($"{RemovedPokemonNumbers.Sum()}");
        }
    }
}

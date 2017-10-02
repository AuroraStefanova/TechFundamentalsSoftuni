using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonEvolution = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                var token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string pokemonName = token[0];
                string evolutioType = token[1];
                int indexOfEvolution = int.Parse(token[2]);


                if (!pokemonEvolution.ContainsKey(pokemonName))
                {
                    pokemonEvolution[pokemonName] = new Dictionary<string, int>();
                }

                if(token.Length == 1)
                {
                    if (pokemonEvolution.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                    }
                }
                else
                {
                    if (!pokemonEvolution[pokemonName].ContainsKey(evolutioType))
                    {
                        pokemonEvolution[pokemonName][evolutioType] = 0;
                    }
                    pokemonEvolution[pokemonName][evolutioType] = indexOfEvolution;
                }


                input = Console.ReadLine();
            }
            foreach (var pokemon in pokemonEvolution)
            {

                foreach (var kvp in pokemon.Value)
                {

                }
            }
        }
    }
}

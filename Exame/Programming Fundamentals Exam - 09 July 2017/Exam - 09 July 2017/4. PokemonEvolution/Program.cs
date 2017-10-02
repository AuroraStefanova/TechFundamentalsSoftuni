using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.PokemonEvolution
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string,int>> evolution = new Dictionary<string, SortedDictionary<string,int>>();
            // pokemonName dict-str-> pokemonType dict-str-> evolutionIndex 
            string[] inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0]!= "wubbalubbadubdub")
            {
                string pokemonName = inputLine[0];
                string[] pokemonEvolution = inputLine[1].Split();
                if(pokemonEvolution == null)/////////////////////
                {
                    foreach (var item in evolution)
                    {
                        var poke = item.Key;
                        Console.WriteLine($"# {poke}");
                        foreach (var kvp in item.Value)
                        {
                            Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
                        }
                        continue;
                    }
                }
                else
                {
                     pokemonEvolution = inputLine[1].Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                
                //string[] pokemonEvolution = inputLine[1].Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                // this fucking split is a problem .|.

               // bool isEmpty = !pokemonEvolution.Any();
               // if (isEmpty)
               // {
               //     /// printira pokemona i prostotiqta mu 
               //
               // }
               // else
               // {
                    if (!evolution.ContainsKey(pokemonName))
                    {
                        evolution[pokemonName] = new SortedDictionary<string, int>();
                    }

                    int index = int.Parse(inputLine[2]);
                    foreach (var evP in pokemonEvolution)
                    {
                        if (!evolution[pokemonName].ContainsKey(evP))
                        {
                            evolution[pokemonName][evP] = index;
                        }
                    }
                }

                inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in evolution)
            {
                var poke = item.Key;
                Console.WriteLine($"# {poke}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
                }
            }
        }  
    }
}

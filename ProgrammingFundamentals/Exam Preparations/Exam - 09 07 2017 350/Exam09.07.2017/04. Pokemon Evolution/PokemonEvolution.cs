using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Pokemon_Evolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "wubbalubbadubdub")
                {
                    break;
                }
                var inputTokens = inputLine
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length == 1)
                {
                    var name = inputTokens[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        for (int i = 1; i < pokemons[name].Count; i += 2)
                        {
                            Console.WriteLine($"{pokemons[name][i - 1]} <-> {pokemons[name][i]}");
                        }
                    }
                }
                else if (inputTokens.Length == 3)
                {
                    var name = inputTokens[0];
                    var evolutionType = inputTokens[1];
                    var evolutionIndex = inputTokens[2];

                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons.Add(name, new List<string>());
                    }
                    pokemons[name].Add(evolutionType);
                    pokemons[name].Add(evolutionIndex);
                }
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                List<string> indexAndEvolution = new List<string>();
                for (int i = 1; i < pokemon.Value.Count; i += 2)
                {
                    var stringToAdd = $"{pokemon.Value[i]} {pokemon.Value[i - 1]}";
                    indexAndEvolution.Add(stringToAdd);
                }
                foreach (var index in indexAndEvolution
                    .OrderByDescending(i => i.Split(' ').Select(int.Parse).First()))
                {
                    var indexTokens = index.Split(' ').ToArray();
                    var ind = indexTokens[0];
                    var evolution = indexTokens[1];
                    Console.WriteLine($"{evolution} <-> {ind}");
                }
            }
        }
    }
}

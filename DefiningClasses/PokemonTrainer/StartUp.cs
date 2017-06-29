using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        string input;
        var trainers = new List<Trainer>();

        while ((input = Console.ReadLine()) != "Tournament")
        {
            var info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var trainerName = info[0];
            var pokemonName = info[1];
            var pokemonElement = info[2];
            var pokemonHealth = int.Parse(info[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            var index = trainers.FindIndex(t => t.Name == trainerName);

            if (index >= 0)
            {
                trainers[index].Pokemons.Add(pokemon);
            }

            else
            {
                var trainer = new Trainer(trainerName);
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);
            }
        }
        string command;
        var elements = new List<string> { "Fire", "Water", "Electricity" };

        while ((command = Console.ReadLine()) != "End")
        {
            if (elements.Contains(command))
            {
                foreach (var tr in trainers)
                {
                    var count = 0;

                    foreach (var pokemon in tr.Pokemons)
                    {
                        if (pokemon.Element == command)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count != 0)
                    {
                        tr.Badges += 1;
                    }

                    else
                    {
                        foreach (var pokemon in tr.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        tr.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}


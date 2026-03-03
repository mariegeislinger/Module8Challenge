﻿using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Filtering and Sorting A List of Video Games
/// </summary>
namespace VideoGames
class VideoGame
{
    //Attributes of VideoGame
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public int Rating { get; set; }
}

///LINQ Lab Contains are main method
///This is the first method that will be called when the program runs
class PokemonLINQLab
{
    public static void Main()
    {
        // Sample data: list of Pokemon
        var videogames = new List<VideoGame>
           List<VideoGame> games = new List<VideoGame>();
        {
            
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5});
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25 },
            new Pokemon { Id = 6, Name = "Jigglypuff", Type = "Normal", Level = 20 }
        };

        // LINQ Query: find Pokemon ready to evolve (level 16 for first evolution)
        //THis is a collection that will hold multiple values
        //p is alias for pokeman
        //Test run with descending
        //Test run with less than


        var topRatedGames = (from game in games
                     where game.Rating >= 4
                     select game).ToList();


        var sortedGames = (from game in topRatedGames
                   orderby game.Name
                   select game).ToList();

        foreach (var game in sortedGames)
        {
        Console.WriteLine(game.Name);
        }
        var readyToEvolve = from p in pokemons
                            where p.Level <= 16
                            orderby p.Level descending
                            select p;

        // Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve:");
        foreach (var p in readyToEvolve)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }
    }
}
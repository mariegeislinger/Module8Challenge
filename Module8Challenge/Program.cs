using System;
using System.Collections.Generic;
using System.Linq;

class VideoGame
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public double Rating { get; set; }
}

class VideoGames
{
    static void Main()
    {
        // Sample data: list of games
        var games = new List<VideoGame>
        {
            new VideoGame { Id = 1, Name = "Contra", Genre = "Battle", Rating = 4.5 },
            new VideoGame { Id = 2, Name = "Mortal Kombat", Genre = "Battle", Rating = 3.0 },
            new VideoGame { Id = 3, Name = "Sims", Genre = "Role Playing", Rating = 5.0 },
            new VideoGame { Id = 4, Name = "Roller Coaster Tycoon", Genre = "Building", Rating = 3.0 },
            new VideoGame { Id = 5, Name = "Typer Shark", Genre = "Education", Rating = 5.0 }
        };

        // LINQ Query: find top-rated games
        var topRatedGames =
            from g in games
            where g.Rating >= 4
            orderby g.Rating
            select g;

        // Display results
        Console.WriteLine("Top Rated Video Games:");
        foreach (var g in topRatedGames)
        {
            Console.WriteLine($"Name: {g.Name}, Genre: {g.Genre}, Rating: {g.Rating}");
        }
    }
}
using System;
using System.Linq;

namespace LINQ_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("SA2", 'E', "Racing"),
                new Game("Sonic CD", 'E', "Platformer"),
                new Game("MKX", 'M', "Fighting"),
                new Game("ME3", 'M', "Action RPG"),
                new Game("Sonic 2", 'E', "Platformer"),
                new Game("CoD4: MW", 'M', "FPS"),
                new Game("SW:TOR", 'T', "MMO RPG"),
                new Game("CoD 2", 'M', "First-Person Shooter"),
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("MK11", 'M', "Fighting")
            };

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")
                            .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre {game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games:");
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}
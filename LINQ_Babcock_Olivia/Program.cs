using System;
using System.Linq;

namespace LINQ_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an array for game.
            Game[] games = new Game[]
            {
                // Lists all games and their properties.
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

            // Creates a LINQ Query to get all games with 9 letters or less and assings it to a var.
            var shortGames = from game in games
                             where game.Title.Length < 9
                             // Prints game title(s) with an uppercase letter
                             select $"Game Title: {game.Title.ToUpper()}";

            // Sets a foreach loop for shortGames.
            foreach (var game in shortGames)
            {
                // Prints game(s) to the console.
                Console.WriteLine(game);
            }

            // Creates a LINQ Query to find Minecraft in the array and assign a var to it.
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                            .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre {game.Genre}");

            // Prints all of the game properties of Minecraft.
            Console.WriteLine(mineCraft.FirstOrDefault());

            // Creats a LINQ Query to find T rated games in the array and assign a var to it.
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            // Prints to the console.
            Console.WriteLine("T Rated Games:");
            // Creates a foreach loop for tRated.
            foreach (var game in tRated)
            {
                // Prints game(s) to the console.
                Console.WriteLine(game);
            }

            // Creats a LINQ Query to find E rated action games in the array and assign a var to it.
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            // Prints to the console.
            Console.WriteLine("E Rated Action Games:");
            // Creates a foreach loop for eRatedAction
            foreach (var game in eRatedAction)
            {
                // Prints game(s) to the console.
                Console.WriteLine(game);
            }
        }
    }
}
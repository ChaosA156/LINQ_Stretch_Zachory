using System;
using System.Linq;
namespace LINQ_Stretch_Zachory
{
    //All of the games
    class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Halo: Reach", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Souls-Like"),
                new Game("Killer Instinct", 'M', "Fighting"),
                new Game("SoulCalibur VI", 'T', "Fighting"),
                new Game("Little Nightmares", 'T', "Horror"),
                new Game("Pac-Man", 'E', "Arcade"),
                new Game("Halo: Combat Evolved", 'M', "FPS"),
                new Game("Halo 2", 'M', "FPS"),
                new Game("Halo 3", 'M', "FPS"),
                new Game("Halo Wars", 'T', "Strategy")
            };

            //Prints all of the games to the console.
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }

            //Prints Halo: Reach to the console.
            var haloReach = games.Where(game => game.Title == "Halo: Reach")
                            .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(haloReach.FirstOrDefault());

            //Finds and prints all of the Teen rated games to the console.
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games: ");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            //Finds and prints all of the Mature rated First Person Shooter games to the console.
            var mRatedFps = from game in games
                            where game.Esrb == 'M' && game.Genre.Contains("FPS")
                            select game.Title;

            Console.WriteLine("M Rated FPS Games: ");
            foreach (var game in mRatedFps)
            {
                Console.WriteLine(game);
            }
        }
    }
}
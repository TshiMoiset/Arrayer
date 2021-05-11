using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            //string[] planets = { "Proxima Centauri B", "Proxima Centauri C", "Kepler-1229b", "Kepler-442b", "Kepler-186f" };
            string[] planets = { "KEPLER-438B", "KEPLER-452B", "Proxima Centauri B", "KEPLER-186F", "Proxima Centauri C", "GLISE-667CC", "KEPLER-62E", "GLIESE-581G", "KEPLER-22B" };

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hej och välkomen ombord på Novax (Nova Explore).");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tryck [ENTER] för att se resealternativ.");

            answer = Console.ReadLine().ToLower();

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + planets[i]);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

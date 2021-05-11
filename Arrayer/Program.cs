using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            //string[] planets = { "Proxima Centauri B", "Proxima Centauri C", "Kepler-1229b", "Kepler-442b", "Kepler-186f" };
            string[] planets = { "KEPLER-438B", "KEPLER-452B", "PROXIMA-B", "KEPLER-186F", "KEPLER-62F", "GLISE-667CC", "KEPLER-62E", "GLIESE-581G", "KEPLER-22B" };

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hej och välkomen ombord på Novax (Nova Explore).");
            Console.WriteLine("Tryck [ENTER] för att se resealternativ");

            answer = Console.ReadLine().ToLower();

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine($"{planets}");
            }


            Console.ReadLine();

        }
    }
}

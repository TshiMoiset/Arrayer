using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int planetChoice = 0;

            //string[] planets = { "Proxima Centauri B", "Proxima Centauri C", "Kepler-1229b", "Kepler-442b", "Kepler-186f" };
            string[] planets = { "KEPLER-438B", "KEPLER-452B", "Proxima Centauri B", "KEPLER-186F", "Proxima Centauri C", "GLISE-667CC", "KEPLER-62E", "GLIESE-581G", "KEPLER-22B" };

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hej och välkomen ombord på Novax (Nova Explore).");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Tryck [ENTER] för att se resealternativ.");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Välj vilken planet du vill resa till med siffrorna [1- 9]");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + planets[i]);
                Console.WriteLine();
            }


            while (!int.TryParse(Console.ReadLine(), out planetChoice))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ERROR!!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Välj en siffra mellan [1 - 9]");
            }

            switch (planetChoice)
            {
                case "1":
                    Console.WriteLine($"Du har valt att åka till {planets[0]}");
                    break;

                case "2":
                    Console.WriteLine($"Du har valt att åka till {planets[1]}");
                    break;

                case "3":
                    Console.WriteLine($"Du har valt att åka till {planets[2]}");
                    break;

                case "4":
                    Console.WriteLine($"Du har valt att åka till {planets[3]}");
                    break;

                case "5":
                    Console.WriteLine($"Du har valt att åka till {planets[4]}");
                    break;

                case "6":
                    Console.WriteLine($"Du har valt att åka till {planets[5]}");
                    break;

                case "7":
                    Console.WriteLine($"Du har valt att åka till {planets[6]}");
                    break;

                case "8":
                    Console.WriteLine($"Du har valt att åka till {planets[7]}");
                    break;

                case "9":
                    Console.WriteLine($"Du har valt att åka till {planets[8]}");
                    break;
                default:
                    Console.WriteLine("ERROR!!!", ConsoleColor.Red);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.ReadLine();

        }

    }
}


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

            Console.WriteLine("Hej och välkomen ombord på Avalon.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Tryck [ENTER] för att se resealternativen.");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Välj vilken planet du vill resa till mellan siffrorna [1 - 9]");
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

            Console.ForegroundColor = ConsoleColor.Yellow;

            Random random = new Random();
            /*Random daysToTravell = new Random();
            Random yearsToTravell = new Random();
            Random monthsToTravell = new Random();*/

            int years = 0;
            int days = 0;
            int months = 0;

            switch (planetChoice)
            {
                case 1:
                    years = random.Next(400, 500);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[0]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 2:
                    years = random.Next(1400, 1500);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[1]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 3:
                    years = random.Next(4, 10);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[2]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 4:
                    years = random.Next(500, 600);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[3]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 5:
                    years = random.Next(4, 10);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[4]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 6:
                    years = random.Next(20, 30);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[5]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 7:
                    years = random.Next(1200, 1300);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[6]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 8:
                    years = random.Next(20, 30);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[7]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;

                case 9:
                    years = random.Next(500, 600);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[8]}.");
                    Console.WriteLine($"Det kommer att ta {years}:år {days}:dagar {months}:månader");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!!!");
                    Console.WriteLine("Du har inte valt en destination.");
                    Console.WriteLine("Välj ett alternatuv mellan [1 - 9]");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.ReadLine();
        }
    }
}


using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int planetChoice = 0;

            string[] planets = { "KEPLER-438B", "KEPLER-452B", "Proxima Centauri B", "KEPLER-186F", "Proxima Centauri C", "GLISE-667CC", "KEPLER-62E", "GLIESE-581G", "KEPLER-22B" }; //Arrayen innehåller 9 olika planeter.

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

            for (int i = 0; i < planets.Length; i++)        //Loopen kommer att kösa igronm arrayen så att varje planet skrivs ut.
            {
                Console.WriteLine(i + 1 + ". " + planets[i]);   // Koden gör så att den punkterar med siffror. EX: 1.KEPLER-438B 2. KEPLER-452B etc. 

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            while (!int.TryParse(Console.ReadLine(), out planetChoice)) // Tryparse gör så att jag ska bara använda mig av siffror när jag svarar.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ERROR!!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Välj en siffra mellan [1 - 9]");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Random random = new Random();

            int years = 0;
            int days = 0;
            int months = 0;

            switch (planetChoice)
            {
                case 1:
                    years = random.Next(450, 500);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[0]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");      // $ tecknet gör att jag kans skriva mina variebler direkt i meningen istället för att skriva + (exempel) +.
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 2:
                    years = random.Next(1400, 1500);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[1]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 3:
                    years = random.Next(4, 10);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[2]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 4:
                    years = random.Next(500, 600);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[3]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 5:
                    years = random.Next(4, 10);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[4]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 6:
                    years = random.Next(20, 30);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[5]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 7:
                    years = random.Next(1200, 1300);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[6]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 8:
                    years = random.Next(20, 30);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.WriteLine($"Du har valt att åka till {planets[7]}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;

                case 9:
                    years = random.Next(500, 600);
                    days = random.Next(1, 365);
                    months = random.Next(1, 12);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"Det kommer att ta:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {years}:år");
                    Console.Write($" {months}:månad(er)");
                    Console.Write($" {days}:dagar");
                    Console.WriteLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Du har inte valt en destination.");
                    Console.WriteLine("Välj ett alternatuv mellan [1 - 9]");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.ReadLine();
        }
    }
}


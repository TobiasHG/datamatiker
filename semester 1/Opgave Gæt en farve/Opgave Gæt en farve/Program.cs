namespace Opgave_Gæt_en_farve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] colors = { "Rød", "Blå", "Grøn", "Gul", "Lilla" };
            ConsoleColor[] consoleColors = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Magenta };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{i + 1}. ");

                Console.ForegroundColor = consoleColors[i];
                Console.WriteLine($"{colors[i]}");
            }

            Console.ResetColor();

            Random random = new Random();
            int chosenColorNumber = random.Next(0, 5);

            int maxAttempts = 3;
            int attempts = 0;

            for (int i = 0; i < maxAttempts; i++)
            {
                Console.ResetColor();
                Console.WriteLine("Gæt farven (1-5): ");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == chosenColorNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tillykke! Du gættede rigtigt!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Forkert gæt. Prøv igen.");
                    attempts++;
                }
            }

            Console.ResetColor();
        }
    }
}

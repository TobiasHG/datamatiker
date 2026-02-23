namespace Opgave_Sten__saks_og_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gameWords = { "Sten", "Saks", "Papir" };

            Console.WriteLine("Velkommen til stens saks papir spillet");

            bool running = true;

            while (running)
            {
                Console.WriteLine("Vælg hvad du vil spille på?");
                Console.WriteLine("1. Sten");
                Console.WriteLine("2. Saks");
                Console.WriteLine("3. PaPir");
                Console.Write("Indtast dit valg (1, 2 eller 3): ");
                int playerChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine($"Du valgte {gameWords[playerChoice]}");

                foreach (string word in gameWords)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(word);
                    Thread.Sleep(500);
                }

                Random random = new Random();
                int computerChoice = random.Next(0, 3);

                Console.WriteLine($"Computeren valgte {gameWords[computerChoice]}");

                bool gameDraw = playerChoice == computerChoice;
                running = gameDraw;

                if (gameDraw)
                {
                    Console.WriteLine("Det er uafgjort!");
                }
                else if ((playerChoice == 0 && computerChoice == 1) || (playerChoice == 1 && computerChoice == 2) || (playerChoice == 2 && computerChoice == 0))
                {
                    Console.WriteLine("Du vinder!");
                }
                else
                {
                    Console.WriteLine("Computeren vinder!");
                }

            }
            


        }
    }
}

namespace Opgave_Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nimBoard = 7;

            Console.WriteLine("Velkommen til spillet nim");
            Console.WriteLine("Du spiller imod computeren");
            Console.WriteLine("Den som står tilbage med den sidst tændstik har tabt");
            Console.WriteLine();

            int readin;
            int computerMove;
            Random random = new Random();

            while (nimBoard > 0)
            {
                for (int i = 0; i < nimBoard; i++)
                {
                    Console.Write("| ");
                }
                Console.WriteLine();

                Console.Write("Hvor mange vil du trække? (1, 2, 3): ");
                readin = Convert.ToInt32(Console.ReadLine());

                if (readin < 1 || readin > 3)
                {
                    Console.WriteLine("Du skal trække mellem 1 og 3 tændstikker");
                    continue;
                }

                if (readin > nimBoard)
                {
                    Console.WriteLine("Du kan ikke trække flere tændstikker end der er på bordet");
                    continue;
                }

                nimBoard -= readin;

                for (int i = 0; i < nimBoard; i++)
                {
                    Console.Write("| ");
                }
                Console.WriteLine();

                if (nimBoard == 0)
                {
                    Console.WriteLine("Du har tabt!");
                    break;
                }



                Thread.Sleep(500);

                computerMove = random.Next(1, 4);

                if(computerMove > nimBoard)
                {
                    computerMove = 1;
                }

                nimBoard -= computerMove;

                Console.WriteLine($"Computeren trak {computerMove} tændstikker");

                if (nimBoard == 0)
                {
                    Console.WriteLine("Du har vundet!");
                    break;
                }



            }
        }
    }
}

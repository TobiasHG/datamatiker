namespace Opgave_Lottotallene
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Random random = new Random();

            int[] winningNumbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                winningNumbers[i] = random.Next(1, 37);
            }
            Array.Sort(winningNumbers);

            int joker = random.Next(1, 37);

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (int i in winningNumbers)
            {
                Console.Write(i);
                Console.Write(" ");
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(joker);
            Console.ResetColor();

        }
    }
}

namespace Opgave_Ball_and_cups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg, hvilket bæger du tror kuglen er i");
            Console.WriteLine("(Tast 1, 2 eller 3 og tryk enter)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t#");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t#");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t#\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t1");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t2");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t3\n");

            Console.ResetColor();

            Console.Write("Dit valg: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int dice = r.Next(1, 3);

            if(userInput == dice)
            {
                Console.WriteLine("Du vandt!");
            }
            else
            {
                Console.WriteLine($"Du tabte bolden var under {dice}");
            }

        }
    }
}

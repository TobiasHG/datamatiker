using System;

namespace Opgave_Plat_eller_krone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plat eller krone ! :)");

            Random random = new Random();

            int coinResult = random.Next(0, 2);

            Console.WriteLine("Vælg plat eller krone (p/k) : ");
            string myChoose = Console.ReadLine();

            if (coinResult == 0)
            {
                Console.WriteLine("Det blev plat !");
            }
            else
            {
                Console.WriteLine("Det blev krone !");
            }

            if (coinResult == 0 && myChoose == "p")
            {
                Console.WriteLine("Du vandt !");
            }
            else if (coinResult == 1 && myChoose == "k") {
                Console.WriteLine("Du vandt !");
            }
            else
            {
                Console.WriteLine("Du tabte !");
            }

        }
    }
}

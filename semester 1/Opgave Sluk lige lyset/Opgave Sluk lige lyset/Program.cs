namespace Opgave_Sluk_lige_lyset
{
    internal class Program
    {
        static List<string> log = new List<string>();

        static void cw(string text)
        {
            log.Add(text);
            Console.WriteLine(text);
        }

        static string rl()
        {
            string readin = Console.ReadLine() ?? "";

            log.Add(readin);

            return readin;
        }

        static void rerender()
        {
            Console.Clear();

            foreach (var line in log)
            {
                Console.WriteLine(line);
            }
        }

        static void Main(string[] args)
        {
            bool running = true;

            string readin;

            cw("Commands:");
            cw("tænd - Tænder for lyset");
            cw("sluk - Slukker for lyset");
            cw("Exit - Exits the program");

            while (running)
            {
                readin = rl().ToLower();

                if (readin == "exit")
                {
                    running = false;
                    continue;
                }
                else if (readin == "tænd")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    rerender();
                }
                else if (readin == "sluk")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    rerender();
                }
                else
                {
                    cw("Prøv igen");
                }

            }
        }
    }
}

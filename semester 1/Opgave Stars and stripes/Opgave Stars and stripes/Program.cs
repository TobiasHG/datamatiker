namespace Opgave_Stars_and_stripes
{
    internal class Program
    {

        // Printer en linje kun med farve
        static void printColorLine(ConsoleColor color, int width, bool newline)
        {
            // sætter farven
            Console.BackgroundColor = color;

            // initialiserer et loop og printer linjen
            for (int i = 0; i < width; i++)
            {
                Console.Write(" ");
            }

            // printer \n hvis newline er true
            if (newline)
            {
                Console.WriteLine();
            }
        }

        // printer en linje med stjerne og farve
        static void printStarsLine(int width, bool shouldOffset)
        {
            //  sætter baggrundsfarven til blå og forgrundsfarven (tekst) til hvid
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // beregn offset til stjernerne så de kan være forskudt.
            int offset = shouldOffset ? 1 : -1;

            // laver et loop med bredden og printer enten en stjerne eller et mellemrum afhængigt af offset og positionen i linjen.
            for (int i = 0; i < width; i++)
            {
                // hvis positionen er korrekt skal den printe en stjerne
                if ( (i + offset) % 4 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        static void Main(string[] args)
        {

            for(int i = 0; i < 26; i++)
            {
                // do the bit with stars.
                if(i < 11)
                {

                    // lav en bool som laver offset hver anden linje så stjernerne er forskudt.
                    bool shouldOffset = (i % 2 == 0);

                    // linje 0 og 10 skal ikke have stjerner.
                    bool blockStars = (i == 0 || i == 10);

                    if (blockStars)
                    {
                        printColorLine(ConsoleColor.Blue, 23, false);
                    }
                    else
                    {
                        printStarsLine(23, shouldOffset);
                    }

                }

                // hvis i er < 11 så har vi printet stjerner.
                // derfor skal vi finde ud af hvor meget vi skal printe nu.
                int w = (i < 11) ? 15 : 38;

                // ændre farven til 2 af de samme i træk og derefter 2 af den anden.
                bool colorSwitch = ((i / 2) % 2 == 0);

                ConsoleColor c = colorSwitch ? ConsoleColor.Red : ConsoleColor.White;

                // printer linjen med farve, bredde og ny linje.
                printColorLine(c, w, true);

            }

            // reset color :D
            Console.ResetColor();
        }
    }
}

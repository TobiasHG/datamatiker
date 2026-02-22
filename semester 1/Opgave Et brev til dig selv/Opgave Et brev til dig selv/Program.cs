using static System.Net.Mime.MediaTypeNames;

namespace Opgave_Et_brev_til_dig_selv
{
    internal class Program
    {

        const string letter = "Hej Tobias\n\nDet her er et brev til dig, fra dig, sendt fra fremtiden.\n\nBliv ved!\n\nDu gør det godt!\n\nHilsen Tobias.";
        
        static int findLongestLine( string text)
        {
            int longestLine = 0;

            // opretter et string array, og splitter teksten hver hvert \n tegn
            string[] linjer = text.Split('\n');

            // løber igennem string array
            for (int i = 0; i < linjer.Length; i++)
            {
                // tjekker om det er den længste linje vi har kigget på so far.
                if (linjer[i].Length > longestLine)
                {
                    // sætter den nye længste linje hvis ovenstående er sandt.
                    longestLine = linjer[i].Length;
                }
            }

            return longestLine;
        }

        static void printLetterLine(string text, int paperWidth)
        {
            // skriv tekst
            Console.Write(text);

            // Beregn rest værdi, dvs hvor meget tomt papir der skal være.
            int restPaper = paperWidth-text.Length;


            for(int i = 0; i < restPaper; i++)
            {
                Console.Write(" ");
            }

            Console.Write("\n");
        }

        static void printLetter(string text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            int longestLine = findLongestLine(letter);

            string[] linjer = text.Split('\n');

            for (int i = 0; i < linjer.Length; i++)
            {
                printLetterLine(linjer[i], longestLine);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args)
        {

            printLetter(letter);

        }

    }
}

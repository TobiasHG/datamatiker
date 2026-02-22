using System.Diagnostics.Tracing;
using System.Text;

namespace Opgave_Morsekoden
{
    internal class Program
    {

        static string charToMorse(char c)
        {
            switch (c)
            {
                /* Bogstaver */
                case 'A': return "·—";
                case 'B': return "—···";
                case 'C': return "—·—·";
                case 'D': return "—··";
                case 'E': return "·";
                case 'F': return "··—·";
                case 'G': return "——·";
                case 'H': return "····";
                case 'I': return "··";
                case 'J': return "·———";
                case 'K': return "—·—";
                case 'L': return "·—··";
                case 'M': return "——";
                case 'N': return "—·";
                case 'O': return "———";
                case 'P': return "·——·";
                case 'Q': return "——·—";
                case 'R': return "·—·";
                case 'S': return "···";
                case 'T': return "—";
                case 'U': return "··—";
                case 'V': return "···—";
                case 'W': return "·——";
                case 'X': return "—··—";
                case 'Y': return "—·——";
                case 'Z': return "——··";

                /* Tal */
                case '0': return "—————";
                case '1': return "·————";
                case '2': return "··———";
                case '3': return "···——";
                case '4': return "····—";
                case '5': return "·····";
                case '6': return "—····";
                case '7': return "——···";
                case '8': return "———··";
                case '9': return "————·";

                default: return "?";
            }
        }
        static string wordToMorse(string word)
        {
            
            StringBuilder sb = new StringBuilder();

            foreach (char c in word)
            {
                sb.Append( charToMorse(c) );
                sb.Append( " " );
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Morse Kode");

            while(true)
            {

                Console.WriteLine("Skriv din sætning: ");
                string sentence = Console.ReadLine().ToUpper();

                string[] words = sentence.Split(' ');

                StringBuilder sb = new StringBuilder();

                foreach (string word in words)
                {
                    sb.Append(wordToMorse(word));
                    sb.Append("   ");
                }

                Console.WriteLine(sb.ToString());
                Console.WriteLine("\n");
            }
            
        }
    }
}

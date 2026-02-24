using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Opgave_Heksen
{
    internal class Program
    {

        static readonly char[] validChars = "0123456789#abcdef".ToCharArray();

        static bool isValidHexidecimal( string hexidecimal)
        {

            StringBuilder sbError = new StringBuilder();

            if (hexidecimal == null)
            {
                sbError.Append("Tried to validate null hexidecimal!\n");
                Console.WriteLine($"Error!\n{sbError.ToString()}");
                return false;
            }

            bool verified = true;

            if ( hexidecimal[0] != '#' )
            {
                sbError.Append("First char must be '#'\n");
                verified = false;
            }

            if( hexidecimal.Length != 7)
            {
                sbError.Append("Lenght must be exact 7\n");
                verified = false;
            }

            foreach(char c in hexidecimal)
            {
                if (!validChars.Contains( char.ToLowerInvariant(c) ))
                {
                    sbError.Append($"found invalid char '{c}'\n");
                    verified = false;
                }
            }

            if (!verified)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error!\n{sbError.ToString()}");
                Console.ResetColor();
            }

            return verified;
        }
        static void Main(string[] args)
        {
            Console.Write("Skriv din hexadecimal her: ");
            string hexhexadecimal = Console.ReadLine();

            if (isValidHexidecimal(hexhexadecimal))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Verified: ");
                Console.ResetColor();
                Console.WriteLine(hexhexadecimal);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Denied: ");
                Console.ResetColor();
                Console.WriteLine(hexhexadecimal);
            }
        }
    }
}

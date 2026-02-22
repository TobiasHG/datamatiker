namespace Opgave_Scrabble
{
    internal class Program
    {
        static int CalculateScrabbleValue(string word)
        {
            int points = 0;
            foreach(char c in word.ToUpper())
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException("Ordet må kun indeholde bogstaver");
                }
                switch (c)
                {
                    case 'E':
                    case 'A':
                    case 'N':
                    case 'R':
                        points += 1;
                        break;

                    case 'D':
                    case 'L':
                    case 'O':
                    case 'S':
                    case 'T':
                        points += 2;
                        break;

                    case 'B':
                    case 'I':
                    case 'K':
                    case 'F':
                    case 'G':
                    case 'M':
                    case 'U':
                    case 'V':
                        points += 3;
                        break;

                    case 'H':
                    case 'J':
                    case 'P':
                    case 'Y':
                    case 'Æ':
                    case 'Ø':
                    case 'Å':
                        points += 4;
                        break;

                    case 'C':
                    case 'X':
                    case 'Z':
                    case 'W':
                    case 'Q':
                        points += 8;
                        break;

                    default:
                        break;
                }

            }

            return points;
        }
        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("Skriv et ord og beregn dens scrabble værdi eller skriv 'exit!' for at afbryde");

            while (running)
            {
                 string readin = Console.ReadLine();

                if (readin.ToLower() == "exit!")
                {
                    running = false;
                    continue;
                }

                int points = CalculateScrabbleValue(readin);

                Console.WriteLine($"Ordet '{readin}' har en scrabble værdi på {points}");

            }
        }
    }
}

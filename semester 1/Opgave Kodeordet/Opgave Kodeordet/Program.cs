using System.Text;

namespace Opgave_Kodeordet
{
    internal class Program
    {

        static readonly string[] alphabet =
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M",
            "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };

        static readonly string[] numbers =
        {
            "0","1","2","3","4","5","6","7","8","9"
        };

        static readonly string[] special =
        {
            "!","#","¤","%","&","/","(",")","[","]","{","}","$","£","@","=","?","+"
        };

        static readonly string[] allChars =
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M",
            "N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
            "0","1","2","3","4","5","6","7","8","9",
            "!","#","¤","%","&","/","(",")","[","]","{","}","$","£","@","=","?","+"
        };

        static readonly Random random = new Random();

        static string[] shuffleStringArray(string[] array)
        {

            for(int i = 0; i < array.Length * 10;  i++)
            {
                int randomPos1 = random.Next(array.Length);
                int randomPos2 = random.Next(array.Length);
                if(randomPos1 == randomPos2)
                {
                    continue;
                }
                string temp = array[randomPos1];
                array[randomPos1] = array[randomPos2];
                array[randomPos2] = temp;
            }

            return array;
        }

        static string generatePassword(int lenght)
        {
            string[] password = new string[lenght];
            password[0] = alphabet[random.Next(alphabet.Length)].ToUpper();
            password[1] = alphabet[random.Next(alphabet.Length)].ToLower();
            password[2] = numbers[random.Next(numbers.Length)];
            password[3] = special[random.Next(special.Length)];

            for (int i  = 4; i  < lenght; i ++)
            {
                string s = allChars[random.Next(allChars.Length)];
                
                if(random.Next(2) == 0)
                {
                    s = s.ToLower();
                    Console.WriteLine("Lower");
                }
                else
                {
                    s = s.ToUpper();
                    Console.WriteLine("Upper");
                }

                password[i] = s;
            }

            shuffleStringArray(password);

            StringBuilder sb = new StringBuilder();

            foreach(string c in password)
            {
                sb.Append(c);
            }

            return sb.ToString();

        }

        static void Main(string[] args)
        {
            Console.Write("Hvor langt skal din kode være (12-128): ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            if (lenght < 12 || lenght > 128)
            {
                Console.WriteLine("Ugyldig længde, prøv igen.");
                return;
            }

            string password = generatePassword(lenght);
            Console.WriteLine($"Din kode er {password}");




        }
    }
}

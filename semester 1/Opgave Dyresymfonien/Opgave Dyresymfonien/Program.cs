using System.Media;

namespace Opgave_Dyresymfonien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sounds = { "Cat", "Monkey" };
            SoundPlayer player;

            bool running = true;

            Random random = new Random();
            int randomIndex = random.Next(sounds.Length);

            string soundLocation = $@"{Environment.CurrentDirectory}/Sounds/{sounds[randomIndex]}.wav";
            Console.WriteLine(soundLocation);
            player = new SoundPlayer(soundLocation);
            player.Play();

            running = true;

            do
            {

                Console.WriteLine("Gæt dyrelyden: ");
                Console.WriteLine("1. Cat");
                Console.WriteLine("2. Monkey");
                Console.Write("skriv dit gæt her: ");
                int readin = Convert.ToInt32(Console.ReadLine()) - 1;

                if(readin == randomIndex)
                {
                    Console.WriteLine("Du gættede rigtigt!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Du gættede forkert, prøv igen.");
                    Thread.Sleep(1000);
                }

                
            } while (running);
            
            

            
        }
    }
}

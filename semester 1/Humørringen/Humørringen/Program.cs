namespace Humørringen
{

    public class MoodRing
    {
        public enum Moods { Happy, Sad, Angry }

        private static Random rnd = new Random();

        public static Moods getRandomMood()
        {

            Moods[] moods = (Moods[])Enum.GetValues(typeof(Moods));

            return moods[rnd.Next(moods.Length)];

        }

        public static void render(Moods mood)
        {

            if (mood == Moods.Happy)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (mood == Moods.Sad)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (mood == Moods.Angry)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.WriteLine("Invalid mood.");
            }


            Console.WriteLine(@"     __");
            Console.WriteLine(@"    /  \");
            Console.WriteLine(@"   _\  /_");
            Console.WriteLine(@"  / ____ \");
            Console.WriteLine(@" / /    \ \");
            Console.WriteLine(@"/ /      \ \");
            Console.WriteLine(@"\ \      / /");
            Console.WriteLine(@" \ \____/ /");
            Console.WriteLine(@"  \______/");

            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MoodRing.Moods mood = MoodRing.getRandomMood();
            MoodRing.render(mood);
            Console.WriteLine($"Du er {mood}");
        }
    }
}

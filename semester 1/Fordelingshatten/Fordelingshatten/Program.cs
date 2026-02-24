namespace Fordelingshatten
{
    
    internal class Program
    {
        private static Random rnd = new Random();
        public enum House
        {
            Gryffindor, Hufflepuff, Ravenclaw, Slytherin
        };

        static House randomHouse()
        {

            House[] houses = (House[])Enum.GetValues(typeof(House));

            return houses[rnd.Next(houses.Length)];
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Du blev {randomHouse()}");
        }
    }
}

namespace Opgave_Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int cubeNumber = random.Next(1, 7);

            Console.WriteLine($"Du slog {cubeNumber}");

        }
    }
}

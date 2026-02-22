namespace Opgave_Fartmåleren
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Fartmåler");

            Console.Write("Indtast hvor mange meter bilen har kørt: ");
            double meters = double.Parse(Console.ReadLine() ?? "0,0");

            Console.Write("Indtast hvor mange sekunder det tog: ");
            int seconds = int.Parse( Console.ReadLine() ?? "0" );

            double speed = (meters / seconds) * 3.6;

            Console.WriteLine($"Bilen kørte {speed} km/t");

        }
    }
}

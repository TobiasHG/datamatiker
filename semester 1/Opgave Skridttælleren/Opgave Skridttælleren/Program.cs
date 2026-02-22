namespace Opgave_Skridttælleren
{
    internal class Program
    {

        static double stringToDouble(string s)
        {
            s = s.Replace(".", ",");
            return double.Parse(s);
        }
        static void Main(string[] args)
        {
            Console.Write("indtast skridt længe i cm: ");
            double stepLenght = stringToDouble(Console.ReadLine() ?? "0.0");

            Console.Write("indtast antal skridt: ");
            double steps = stringToDouble(Console.ReadLine() ?? "0.0");

            double km = (stepLenght * steps) / 100000;

            Console.WriteLine($"du har gået {km}km idag");
        }
    }
}

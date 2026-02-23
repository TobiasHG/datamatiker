namespace Opgave_Tomme_tønder
{
    internal class Program
    {
        static double inputToDouble(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());

        }
        static double calculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        static double calculateSurfaceArea(double radius, double height)
        {
            return 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * height;
        }

        static void Main(string[] args)
        {
            double height = inputToDouble("Indtast højden: ");
            double radius = inputToDouble("Indtast radius: ");

            double volume = calculateVolume(radius, height);
            double surfaceArea = calculateSurfaceArea(radius, height);

            Console.WriteLine($"Volumen: {volume}");
            Console.WriteLine($"Overfladeareal: {surfaceArea}");
        }
    }
}

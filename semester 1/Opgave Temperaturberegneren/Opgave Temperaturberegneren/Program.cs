namespace Opgave_Temperaturberegneren
{
    internal class Program
    {

        static double calculateFahrenheit( double c)
        {
            const double C_TO_F = 9.0 / 5.0;
            return c * C_TO_F + 32;
        }

        static double calculateReamur(double c)
        {
            const double C_TO_R = 4.0 / 5.0;
            return c * C_TO_R;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Temperatur beregner, fra C til F og Reamur");

            while (true)
            {
                Console.Write("Skriv temperatur i C: ");
                string input_c = Console.ReadLine() ?? "0.0";
                input_c = input_c.Replace('.', ',');

                double c = double.Parse(input_c);

                Console.WriteLine($"{c} C = {calculateFahrenheit(c)} Fahrenheit og {calculateReamur(c)} Reamur.\n");
            }
        }
    }
}

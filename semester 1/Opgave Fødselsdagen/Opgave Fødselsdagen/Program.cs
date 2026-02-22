using System.Globalization;

namespace Opgave_Fødselsdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Beregn hvor gammel du er :)");

            Console.Write("Fødselsdag ddmmyyyy: ");
            string readin = Console.ReadLine();

            DateTime birthDate = DateTime.ParseExact(readin, "ddMMyyyy", null);

            Console.WriteLine($"Du er født: {birthDate}");

            DateTime today = DateTime.Today;

            TimeSpan timePassed = today - birthDate;

            int years = (int)Math.Floor(timePassed.TotalDays / 365.2425);

            birthDate = birthDate.AddYears(years);
            timePassed = DateTime.Now - birthDate;

            int days = (int)Math.Floor(timePassed.TotalDays);

            Console.WriteLine($"Du er {years} år og {days} dage gammel.");
        }
    }
}

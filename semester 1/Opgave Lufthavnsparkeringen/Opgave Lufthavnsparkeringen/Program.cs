using System.Runtime.InteropServices;

namespace Opgave_Lufthavnsparkeringen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Har du parkeringslicens (ja/nej): ");
            bool parkingLicense = Console.ReadLine().ToLower() == "ja" ? true : false;

            Console.Write("Har du parkerings Tilladelse (ja/nej): ");
            bool parkingPermit = Console.ReadLine().ToLower() == "ja" ? true : false;

            Console.Write("skriv tidspunkt fx (18:30) eller (6:00): ");
            string timeReadin = Console.ReadLine();

            TimeOnly currentTime = TimeOnly.Parse(timeReadin);
            TimeOnly openFrom = TimeOnly.Parse("08:00");
            TimeOnly closeFrom = TimeOnly.Parse("18:00");

            bool isWithin = currentTime >= openFrom && currentTime <= closeFrom;

            bool canPark = (parkingPermit || (parkingLicense && isWithin));

            if (canPark)
            {
                Console.WriteLine("Parkering tilladt");
            }
            else
            {
                Console.WriteLine("Parkering ikke tilladt");

            }
        }
    }
}

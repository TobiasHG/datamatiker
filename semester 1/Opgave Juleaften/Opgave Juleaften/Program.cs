namespace Opgave_Juleaften
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            int year = 0;

            if (today.Month == 12 && today.Day > 24)
            {
                year = today.Year + 1;
            }
            else
            {
                year = today.Year;
            }

            DateTime christmasDate = new DateTime(year, 12, 24);

            TimeSpan timeUntilChristmas = christmasDate - today;

            Console.WriteLine($"Der er {timeUntilChristmas.Days} dage til juleaften.");
        }
    }
}

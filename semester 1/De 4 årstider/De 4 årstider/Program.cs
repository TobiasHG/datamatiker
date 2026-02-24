namespace De_4_årstider
{

    enum Months
    {
        Januar=1,     // Vinter
        Februar,    // Vinter
        Marts,      // Forår
        April,      // Forår
        Maj,        // Forår
        Juni,       // Sommer
        Juli,       // Sommer
        August,     // Sommer
        September,  // Efterår
        Oktober,    // Efterår
        November,   // Efterår
        December    // Vinter
    }


    internal class Program
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("Tjek årstiden for en måned ");
            Console.WriteLine("Jan=1, Feb=2...December=12");
            Console.Write("Hvilken måned vil du tjekke: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
                case (int)Months.Januar:
                case (int)Months.Februar:
                case (int)Months.December:
                    Console.WriteLine("Vinter");
                    break;

                case (int)Months.Marts:
                case (int)Months.April:
                case (int)Months.Maj:
                    Console.WriteLine("Det jo Forår");
                    break;

                case (int)Months.Juni:
                case (int)Months.Juli:
                case (int)Months.August:
                    Console.WriteLine("Sommer");
                    break;

                case (int)Months.September:
                case (int)Months.Oktober:
                case (int)Months.November:
                    Console.WriteLine("Efterår");
                    break;

                default:
                    Console.WriteLine("Ugyldig måned!");
                    break;
            }
        }
    }
}

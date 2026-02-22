namespace Opgave_Kontrolstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] uddannelser = { "Administrationsøkonom", "Autoteknolog", "Byggetekniker", "Datamatiker" };

            for (int i = 0; i < uddannelser.Length; i++)
            {
                Console.WriteLine($"{i}. {uddannelser[i]}");
            }

            Console.Write("\nVælg uddannelse: ");
            string uddannelseInput = Console.ReadLine();

            if (uddannelseInput == "" || uddannelseInput == null)
            {
                uddannelseInput = "-1";
            }

            int uddannelse = int.Parse(uddannelseInput);

            if (uddannelse == -1)
            {
                Console.WriteLine("Du går ikke på nogen uddanelse :'(");
            }
            else if ( uddannelse == 3 )
            {
                Console.WriteLine("Du går på Datamatiker! <3");
            }
            else
            {
                Console.WriteLine("Buuuuuuh!!");
            }

        }
    }
}

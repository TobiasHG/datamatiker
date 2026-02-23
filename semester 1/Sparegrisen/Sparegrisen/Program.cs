namespace Sparegrisen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sparegrisen");

            Console.Write("Indtast et beløb: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Indtast en rente i procent: ");
            double interestRate = double.Parse(Console.ReadLine());

            Console.Write("Indtast en periode i år: ");
            int years = int.Parse(Console.ReadLine());

            double yearlyInterest = 0;

            for (int i = 1; i <= years; i++)
            {
                yearlyInterest = amount * (interestRate / 100);
                amount += yearlyInterest;

                Console.WriteLine($"Beløb efter {i} år {amount}");
            }

                 
        }
    }
}

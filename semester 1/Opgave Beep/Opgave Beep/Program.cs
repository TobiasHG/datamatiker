namespace Opgave_Beep
{
    internal class Program
    {

        static void Alarm(int times, int sleep)
        {
            for(int i = 0; i < times; i++)
            {
                Console.Beep(3276, 1000);
                Thread.Sleep(sleep);
                Console.Write("BEEP! ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Alarm(5, 250);
        }
    }
}

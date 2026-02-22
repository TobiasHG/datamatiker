namespace Opgave_Frysepunktet
{
    internal class Program
    {

        static bool inRange(double value, double min, double max)
        {
            return value >= min && value <= max;
        }

        static int calculate(double tempGoal, double tempCurrent, double tempMargin)
        {
            if (inRange(tempCurrent, tempGoal - tempMargin, tempGoal + tempMargin))
            {
                return 0;
            }
            else
            {
                if (tempCurrent < tempGoal)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
        static void Main(string[] args)
            {
                Console.Write("Hvad er den ønskede temp: ");
                double tempGoal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hvad er den nuværende temp: ");
                double tempCurrent = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hvad er temp margin: ");
                double tempMargin = Convert.ToDouble(Console.ReadLine());

                double tempDiff = tempCurrent - tempGoal;

                int result = calculate(tempGoal, tempCurrent, tempMargin);

                if (result == 0)
                {
                    Console.WriteLine("Temperaturen er inden for margin");
                }
                else if (result == -1)
                {
                    Console.WriteLine("Temperaturen er for lav");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Temperaturen er for høj");
                }
        }
    }
}

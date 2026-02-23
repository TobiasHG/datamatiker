namespace Opgave_Rumskibet
{
    internal class Program
    {
        static double calculateGrowth(double initialPopulation, double growthRate, int years)
        {
            double rate = growthRate / 100.0;

            for (int i = 0; i < years; i++)
            {
                initialPopulation += initialPopulation * rate;
            }

            return Math.Round(initialPopulation);
        }

        static void Main(string[] args)
        {
            double[,] spaceShips = new double[6, 2] {
                { 5581503, 0.22 }, // Danmark
                { 22751014, 1.07},  // Australien
                { 1986705, -1.06},  // Letland
                { 37731, 0.12},  // Monaco
                { 12042910, 4.02},  // Sydsudan
                { 19625353, 2.78 } // Angola
            };

            for (int i = 0; i < spaceShips.GetLength(0); i++)
            {
                double initialPopulation = spaceShips[i, 0];
                double growthRate = spaceShips[i, 1];
                double finalPopulation = calculateGrowth(initialPopulation, growthRate, 30);
                Console.WriteLine($"Efter 30 år vil rumskibet have {finalPopulation} passagerer.");
            }
        }
    }
}

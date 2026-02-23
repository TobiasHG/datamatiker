namespace Opgave_Vinos_Blancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whineData = new int[] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            
            // opgaven 2
            whineData[5] += +35432;

            int[] whineDataCopy = new int[10];

            Array.Copy(whineData, whineDataCopy, 10);
            whineDataCopy.Sort();

            int max = whineDataCopy[0];
            const byte maxStar = 50;

            

            for (int i = 0; i < whineData.Length; i++)
            {
                int star = maxStar * whineData[i] / max;
                for(int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // opgave 3
            whineData.Sort();

        }
    }
}

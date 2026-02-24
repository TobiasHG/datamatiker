namespace Opgave_DNA
{
    internal class Program
    {

        static int hamming(string a, string b)
        {

            int hamming = 0;
            int longestLength = Math.Max(a.Length, b.Length);
            int diff = Math.Abs(a.Length - b.Length);

            for(int i = 0; i < longestLength-diff; i++)
            {
                if (a[i] != b[i] )
                {
                    hamming += 1;
                }
            }
            

            return hamming + diff;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hamming test: ");
            Console.WriteLine(hamming("Abc", "Abc"));       // 0
            Console.WriteLine(hamming("Abc", "Ab"));        // 1
            Console.WriteLine(hamming("Abc", "AbC2"));      // 2
            Console.WriteLine(hamming("Abc", "Abcd"));      // 1
            Console.WriteLine(hamming("Abc", "Abcd34fwa")); // 6
        }
    }
}

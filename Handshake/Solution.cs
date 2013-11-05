using System;

namespace Handshake
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            while (T > 0)
            {

                long N = Int64.Parse(Console.ReadLine());

                // Num handshakes = N choose 2
                Console.WriteLine(GetBinaryCoefficient(N));

                --T;
            }
        }

        public static long GetBinaryCoefficient(long N)
        {
            long result = 1;
            long i;

            if (2 > N) return 0;

            for (i = 1; i <= 2; i++)
            {
                result *= N--;
                result /= i;
            }

            return result;
        }
    }
}

using System;

namespace Diwali_Lights
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            while (T > 0)
            {
                int bulbCount = Int32.Parse(Console.ReadLine().Trim());
                
                int result = (int)ExponentBySquare(2, bulbCount) - 1;

                Console.WriteLine(result);

                --T;
            }
        }

        public static long ExponentBySquare(long x, long n)
        {
            if (n < 0)
                return ExponentBySquare(1 / x, -n) % 100000;

            else if (n == 0)
                return 1;

            else if (n == 1)
                return x;

            else if (n % 2 == 0)
                return ExponentBySquare((long)Math.Pow(x, 2) % 100000, n / 2) % 100000;

            else
                return (x * ExponentBySquare((long)Math.Pow(x, 2) % 100000, (n - 1) / 2)) % 100000;
        }
    }
}

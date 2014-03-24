using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int NumTestCases = Int32.Parse(Console.ReadLine().Trim());

            while (NumTestCases > 0)
            {
                --NumTestCases;

                int N = Int32.Parse(Console.ReadLine().Trim());

                int ceil = (int)Math.Ceiling((double)N / 2) + 1;

                if (N % 2 == 0)
                    Console.WriteLine(Math.Pow(2, ceil) - 1);

                else
                    Console.WriteLine(Math.Pow(2, ceil) - 2);

                // Monsoon season: doubles in height.
                // Second growth season is summer when it increases by 1.
                // 0 -> 1       // 2^1 - 1
                // 1 -> 2       // 2^2 - 2
                // 2 -> 3       // 2^2 - 1
                // 3 -> 6       // 2^3 - 2
                // 4 -> 7       // 2^3 - 1
                // 5 -> 14      // 2^4 - 2
                // 6 -> 15      // 2^4 - 1
                // 7 -> 30      // 2^5 - 2
                // 8 -> 31      // 2^5 - 1
                // 9 -> 62      // 2^6 - 2
                // 10 -> 63     // 2^6 - 1
                // 11 -> 126    // 2^7 - 2
                // 12 -> 127    // 2^7 - 1
            }
        }
    }
}
